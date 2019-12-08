using FallenHero.Features;
using FallenHero.Manager;
using FallenHero.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FallenHero.Other.Enums;

namespace FallenHero
{
    public partial class Form1 : Form
    {
        List<ItemDefinitionIndex> completeWeapondefinitionList;
        List<ItemDefinitionIndex> weaponsList;

        Dictionary<int, string> completeSkinList;
        Dictionary<int, string> sortedSkinList;

        List<string> cfgList;

        bool isAttached;
        Thread reader;
        Thread bhop;
        Thread trigger;
        Thread skins;
        Thread boxEsp;
        
        public Form1()
        {
            this.Name = Guid.NewGuid().ToString().Replace("-", "");
            InitializeComponent();
            InitializeMyStuff();
        }
        private void InitializeThreads()
        {
            reader = new Thread(Reader.Run);
            bhop = new Thread(Bhop.Run);
            trigger = new Thread(Trigger.Run);
            skins = new Thread(Skinchanger.Run);
            boxEsp = new Thread(BoxEsp.Run);

            reader.Start();
            bhop.Start();
            trigger.Start();
            skins.Start();
            boxEsp.Start();
        }

        private void InitializeMyStuff()
        {
            cfgList = new List<string>();
            RefreshCfgList();

            isAttached = false;
            completeWeapondefinitionList = Enum.GetValues(typeof(ItemDefinitionIndex)).Cast<ItemDefinitionIndex>().ToList();
            weaponsList = completeWeapondefinitionList.Where(item => item.ToString().StartsWith("WEAPON")).ToList();
            cmbWeapon.DataSource = weaponsList;

            completeSkinList = new Dictionary<int, string>();
            completeSkinList.Add(2, "Groundwater");
            completeSkinList.Add(3, "Candy Apple");
            completeSkinList.Add(5, "Forest DDPAT");
            completeSkinList.Add(6, "Arctic Camo");
            completeSkinList.Add(8, "Desert Storm");
            completeSkinList.Add(9, "Bengal Tiger");
            completeSkinList.Add(10, "Copperhead");
            completeSkinList.Add(11, "Skulls");
            completeSkinList.Add(12, "Crimson Web");
            completeSkinList.Add(13, "Blue Streak");
            completeSkinList.Add(14, "Red Laminate");
            completeSkinList.Add(15, "Gunsmoke");
            completeSkinList.Add(16, "Jungle Tiger");
            completeSkinList.Add(17, "Urban DDPAT");
            completeSkinList.Add(20, "Virus");
            completeSkinList.Add(21, "Granite Marbleized");
            completeSkinList.Add(22, "Contrast Spray");
            completeSkinList.Add(25, "Forest Leaves");
            completeSkinList.Add(26, "Lichen Dashed");
            completeSkinList.Add(27, "Bone Mask");
            completeSkinList.Add(28, "Anodized Navy");
            completeSkinList.Add(30, "Snake Camo");
            completeSkinList.Add(32, "Silver");
            completeSkinList.Add(33, "Hot Rod");
            completeSkinList.Add(34, "Metallic DDPAT");
            completeSkinList.Add(36, "Ossified");
            completeSkinList.Add(37, "Blaze");
            completeSkinList.Add(38, "Fade");
            completeSkinList.Add(39, "Bulldozer");
            completeSkinList.Add(40, "Night");
            completeSkinList.Add(41, "Copper");
            completeSkinList.Add(42, "Blue Steel");
            completeSkinList.Add(43, "Stained");
            completeSkinList.Add(44, "Case Hardened");
            completeSkinList.Add(46, "Contractor");
            completeSkinList.Add(47, "Colony");
            completeSkinList.Add(48, "Dragon Tattoo");
            completeSkinList.Add(51, "Lightning Strike");
            completeSkinList.Add(59, "Slaughter");
            completeSkinList.Add(60, "Dark Water");
            completeSkinList.Add(61, "Hypnotic");
            completeSkinList.Add(62, "Bloomstick");
            completeSkinList.Add(67, "Cold Blooded");
            completeSkinList.Add(70, "Carbon Fiber");
            completeSkinList.Add(71, "Scorpion");
            completeSkinList.Add(72, "Safari Mesh");
            completeSkinList.Add(73, "Wings");
            completeSkinList.Add(74, "Polar Camo");
            completeSkinList.Add(75, "Blizzard Marbleized");
            completeSkinList.Add(76, "Winter Forest");
            completeSkinList.Add(77, "Boreal Forest");
            completeSkinList.Add(78, "Forest Night");
            completeSkinList.Add(83, "Orange DDPAT");
            completeSkinList.Add(84, "Pink DDPAT");
            completeSkinList.Add(90, "Mudder");
            completeSkinList.Add(92, "Cyanospatter");
            completeSkinList.Add(93, "Caramel");
            completeSkinList.Add(95, "Grassland");
            completeSkinList.Add(96, "Blue Spruce");
            completeSkinList.Add(98, "Ultraviolet");
            completeSkinList.Add(99, "Sand Dune");
            completeSkinList.Add(100, "Storm");
            completeSkinList.Add(101, "Tornado");
            completeSkinList.Add(102, "Whiteout");
            completeSkinList.Add(104, "Grassland Leaves");
            completeSkinList.Add(107, "Polar Mesh");
            completeSkinList.Add(110, "Condemned");
            completeSkinList.Add(111, "Glacier Mesh");
            completeSkinList.Add(116, "Sand Mesh");
            completeSkinList.Add(119, "Sage Spray");
            completeSkinList.Add(122, "Jungle Spray");
            completeSkinList.Add(124, "Sand Spray");
            completeSkinList.Add(135, "Urban Perforated");
            completeSkinList.Add(136, "Waves Perforated");
            completeSkinList.Add(141, "Orange Peel");
            completeSkinList.Add(143, "Urban Masked");
            completeSkinList.Add(147, "Jungle Dashed");
            completeSkinList.Add(148, "Sand Dashed");
            completeSkinList.Add(149, "Urban Dashed");
            completeSkinList.Add(151, "Jungle");
            completeSkinList.Add(153, "Demolition");
            completeSkinList.Add(154, "Afterimage");
            completeSkinList.Add(155, "Bullet Rain");
            completeSkinList.Add(156, "Death by Kitty");
            completeSkinList.Add(157, "Palm");
            completeSkinList.Add(158, "Walnut");
            completeSkinList.Add(159, "Brass");
            completeSkinList.Add(162, "Splash");
            completeSkinList.Add(164, "Modern Hunter");
            completeSkinList.Add(165, "Splash Jam");
            completeSkinList.Add(166, "Blaze Orange");
            completeSkinList.Add(167, "Radiation Hazard");
            completeSkinList.Add(168, "Nuclear Threat");
            completeSkinList.Add(169, "Fallout Warning");
            completeSkinList.Add(170, "Predator");
            completeSkinList.Add(171, "Irradiated Alert");
            completeSkinList.Add(172, "Black Laminate");
            completeSkinList.Add(174, "BOOM");
            completeSkinList.Add(175, "Scorched");
            completeSkinList.Add(176, "Faded Zebra");
            completeSkinList.Add(177, "Memento");
            completeSkinList.Add(178, "Doomkitty");
            completeSkinList.Add(179, "Nuclear Threat");
            completeSkinList.Add(180, "Fire Serpent");
            completeSkinList.Add(181, "Corticera");
            completeSkinList.Add(182, "Emerald Dragon");
            completeSkinList.Add(183, "Overgrowth");
            completeSkinList.Add(184, "Corticera");
            completeSkinList.Add(185, "Golden Koi");
            completeSkinList.Add(186, "Wave Spray");
            completeSkinList.Add(187, "Zirka");
            completeSkinList.Add(188, "Graven");
            completeSkinList.Add(189, "Bright Water");
            completeSkinList.Add(190, "Black Limba");
            completeSkinList.Add(191, "Tempest");
            completeSkinList.Add(192, "Shattered");
            completeSkinList.Add(193, "Bone Pile");
            completeSkinList.Add(194, "Spitfire");
            completeSkinList.Add(195, "Demeter");
            completeSkinList.Add(196, "Emerald");
            completeSkinList.Add(197, "Anodized Navy");
            completeSkinList.Add(198, "Hazard");
            completeSkinList.Add(199, "Dry Season");
            completeSkinList.Add(200, "Mayan Dreams");
            completeSkinList.Add(201, "Palm");
            completeSkinList.Add(202, "Jungle DDPAT");
            completeSkinList.Add(203, "Rust Coat");
            completeSkinList.Add(204, "Mosaico");
            completeSkinList.Add(205, "Jungle");
            completeSkinList.Add(206, "Tornado");
            completeSkinList.Add(207, "Facets");
            completeSkinList.Add(208, "Sand Dune");
            completeSkinList.Add(209, "Groundwater");
            completeSkinList.Add(210, "Anodized Gunmetal");
            completeSkinList.Add(211, "Ocean Foam");
            completeSkinList.Add(212, "Graphite");
            completeSkinList.Add(213, "Ocean Foam");
            completeSkinList.Add(214, "Graphite");
            completeSkinList.Add(215, "X - Ray");
            completeSkinList.Add(216, "Blue Titanium");
            completeSkinList.Add(217, "Blood Tiger");
            completeSkinList.Add(218, "Hexane");
            completeSkinList.Add(219, "Hive");
            completeSkinList.Add(220, "Hemoglobin");
            completeSkinList.Add(221, "Serum");
            completeSkinList.Add(222, "Blood in the Water");
            completeSkinList.Add(223, "Nightshade");
            completeSkinList.Add(224, "Water Sigil");
            completeSkinList.Add(225, "Ghost Camo");
            completeSkinList.Add(226, "Blue Laminate");
            completeSkinList.Add(227, "Electric Hive");
            completeSkinList.Add(228, "Blind Spot");
            completeSkinList.Add(229, "Azure Zebra");
            completeSkinList.Add(230, "Steel Disruption");
            completeSkinList.Add(231, "Cobalt Disruption");
            completeSkinList.Add(232, "Crimson Web");
            completeSkinList.Add(233, "Tropical Storm");
            completeSkinList.Add(234, "Ash Wood");
            completeSkinList.Add(235, "VariCamo");
            completeSkinList.Add(236, "Night Ops");
            completeSkinList.Add(237, "Urban Rubble");
            completeSkinList.Add(238, "VariCamo Blue");
            completeSkinList.Add(240, "CaliCamo");
            completeSkinList.Add(241, "Hunting Blind");
            completeSkinList.Add(242, "Army Mesh");
            completeSkinList.Add(243, "Gator Mesh");
            completeSkinList.Add(244, "Teardown");
            completeSkinList.Add(245, "Army Recon");
            completeSkinList.Add(246, "Amber Fade");
            completeSkinList.Add(247, "Damascus Steel");
            completeSkinList.Add(248, "Red Quartz");
            completeSkinList.Add(249, "Cobalt Quartz");
            completeSkinList.Add(250, "Full Stop");
            completeSkinList.Add(251, "Pit Viper");
            completeSkinList.Add(252, "Silver Quartz");
            completeSkinList.Add(253, "Acid Fade");
            completeSkinList.Add(254, "Nitro");
            completeSkinList.Add(255, "Asiimov");
            completeSkinList.Add(256, "The Kraken");
            completeSkinList.Add(257, "Guardian");
            completeSkinList.Add(258, "Mehndi");
            completeSkinList.Add(259, "Redline");
            completeSkinList.Add(260, "Pulse");
            completeSkinList.Add(261, "Marina");
            completeSkinList.Add(262, "Rose Iron");
            completeSkinList.Add(263, "Rising Skull");
            completeSkinList.Add(264, "Sandstorm");
            completeSkinList.Add(265, "Kami");
            completeSkinList.Add(266, "Magma");
            completeSkinList.Add(267, "Cobalt Halftone");
            completeSkinList.Add(268, "Tread Plate");
            completeSkinList.Add(269, "The Fuschia Is Now");
            completeSkinList.Add(270, "Victoria");
            completeSkinList.Add(271, "Undertow");
            completeSkinList.Add(272, "Titanium Bit");
            completeSkinList.Add(273, "Heirloom");
            completeSkinList.Add(274, "Copper Galaxy");
            completeSkinList.Add(275, "Red FragCam");
            completeSkinList.Add(276, "Panther");
            completeSkinList.Add(277, "Stainless");
            completeSkinList.Add(278, "Blue Fissure");
            completeSkinList.Add(279, "Asiimov");
            completeSkinList.Add(280, "Chameleon");
            completeSkinList.Add(281, "Corporal");
            completeSkinList.Add(282, "Redline");
            completeSkinList.Add(283, "Trigon");
            completeSkinList.Add(284, "Heat");
            completeSkinList.Add(285, "Terrain");
            completeSkinList.Add(286, "Antique");
            completeSkinList.Add(287, "Pulse");
            completeSkinList.Add(288, "Sergeant");
            completeSkinList.Add(289, "Sandstorm");
            completeSkinList.Add(290, "Guardian");
            completeSkinList.Add(291, "Heaven Guard");
            completeSkinList.Add(293, "Death Rattle");
            completeSkinList.Add(294, "Green Apple");
            completeSkinList.Add(295, "Franklin");
            completeSkinList.Add(296, "Meteorite");
            completeSkinList.Add(297, "Tuxedo");
            completeSkinList.Add(298, "Army Sheen");
            completeSkinList.Add(299, "Caged Steel");
            completeSkinList.Add(300, "Emerald Pinstripe");
            completeSkinList.Add(301, "Atomic Alloy");
            completeSkinList.Add(302, "Vulcan");
            completeSkinList.Add(303, "Isaac");
            completeSkinList.Add(304, "Slashed");
            completeSkinList.Add(305, "Torque");
            completeSkinList.Add(306, "Antique");
            completeSkinList.Add(307, "Retribution");
            completeSkinList.Add(308, "Kami");
            completeSkinList.Add(309, "Howl");
            completeSkinList.Add(310, "Curse");
            completeSkinList.Add(311, "Desert Warfare");
            completeSkinList.Add(312, "Cyrex");
            completeSkinList.Add(313, "Orion");
            completeSkinList.Add(314, "Heaven Guard");
            completeSkinList.Add(315, "Poison Dart");
            completeSkinList.Add(316, "Jaguar");
            completeSkinList.Add(317, "Bratatat");
            completeSkinList.Add(318, "Road Rash");
            completeSkinList.Add(319, "Detour");
            completeSkinList.Add(320, "Red Python");
            completeSkinList.Add(321, "Master Piece");
            completeSkinList.Add(322, "Nitro");
            completeSkinList.Add(323, "Rust Coat");
            completeSkinList.Add(325, "Chalice");
            completeSkinList.Add(326, "Knight");
            completeSkinList.Add(327, "Chainmail");
            completeSkinList.Add(328, "Hand Cannon");
            completeSkinList.Add(329, "Dark Age");
            completeSkinList.Add(330, "Briar");
            completeSkinList.Add(332, "Royal Blue");
            completeSkinList.Add(333, "Indigo");
            completeSkinList.Add(334, "Twist");
            completeSkinList.Add(335, "Module");
            completeSkinList.Add(336, "Desert - Strike");
            completeSkinList.Add(337, "Tatter");
            completeSkinList.Add(338, "Pulse");
            completeSkinList.Add(339, "Caiman");
            completeSkinList.Add(340, "Jet Set");
            completeSkinList.Add(341, "First Class");
            completeSkinList.Add(342, "Leather");
            completeSkinList.Add(343, "Commuter");
            completeSkinList.Add(344, "Dragon Lore");
            completeSkinList.Add(345, "First Class");
            completeSkinList.Add(346, "Coach Class");
            completeSkinList.Add(347, "Pilot");
            completeSkinList.Add(348, "Red Leather");
            completeSkinList.Add(349, "Osiris");
            completeSkinList.Add(350, "Tigris");
            completeSkinList.Add(351, "Conspiracy");
            completeSkinList.Add(352, "Fowl Play");
            completeSkinList.Add(353, "Water Elemental");
            completeSkinList.Add(354, "Urban Hazard");
            completeSkinList.Add(355, "Desert - Strike");
            completeSkinList.Add(356, "Koi");
            completeSkinList.Add(357, "Ivory");
            completeSkinList.Add(358, "Supernova");
            completeSkinList.Add(359, "Asiimov");
            completeSkinList.Add(360, "Cyrex");
            completeSkinList.Add(361, "Abyss");
            completeSkinList.Add(362, "Labyrinth");
            completeSkinList.Add(363, "Traveler");
            completeSkinList.Add(364, "Business Class");
            completeSkinList.Add(365, "Olive Plaid");
            completeSkinList.Add(366, "Green Plaid");
            completeSkinList.Add(367, "Reactor");
            completeSkinList.Add(368, "Setting Sun");
            completeSkinList.Add(369, "Nuclear Waste");
            completeSkinList.Add(370, "Bone Machine");
            completeSkinList.Add(371, "Styx");
            completeSkinList.Add(372, "Nuclear Garden");
            completeSkinList.Add(373, "Contamination");
            completeSkinList.Add(374, "Toxic");
            completeSkinList.Add(375, "Radiation Hazard");
            completeSkinList.Add(376, "Chemical Green");
            completeSkinList.Add(377, "Hot Shot");
            completeSkinList.Add(378, "Fallout Warning");
            completeSkinList.Add(379, "Cerberus");
            completeSkinList.Add(380, "Wasteland Rebel");
            completeSkinList.Add(381, "Grinder");
            completeSkinList.Add(382, "Murky");
            completeSkinList.Add(383, "Basilisk");
            completeSkinList.Add(384, "Griffin");
            completeSkinList.Add(385, "Firestarter");
            completeSkinList.Add(386, "Dart");
            completeSkinList.Add(387, "Urban Hazard");
            completeSkinList.Add(388, "Cartel");
            completeSkinList.Add(389, "Fire Elemental");
            completeSkinList.Add(390, "Highwayman");
            completeSkinList.Add(391, "Cardiac");
            completeSkinList.Add(392, "Delusion");
            completeSkinList.Add(393, "Tranquility");
            completeSkinList.Add(394, "Cartel");
            completeSkinList.Add(395, "Man - o'-war");
            completeSkinList.Add(396, "Urban Shock");
            completeSkinList.Add(397, "Naga");
            completeSkinList.Add(398, "Chatterbox");
            completeSkinList.Add(399, "Catacombs");
            completeSkinList.Add(400, "龍王(Dragon King)");
            completeSkinList.Add(401, "System Lock");
            completeSkinList.Add(402, "Malachite");
            completeSkinList.Add(403, "Deadly Poison");
            completeSkinList.Add(404, "Muertos");
            completeSkinList.Add(405, "Serenity");
            completeSkinList.Add(406, "Grotto");
            completeSkinList.Add(407, "Quicksilver");
            completeSkinList.Add(409, "Tiger Tooth");
            completeSkinList.Add(410, "Damascus Steel");
            completeSkinList.Add(411, "Damascus Steel");
            completeSkinList.Add(413, "Marble Fade");
            completeSkinList.Add(414, "Rust Coat");
            completeSkinList.Add(415, "Doppler");
            completeSkinList.Add(416, "Doppler");
            completeSkinList.Add(417, "Doppler");
            completeSkinList.Add(418, "Doppler");
            completeSkinList.Add(419, "Doppler");
            completeSkinList.Add(420, "Doppler");
            completeSkinList.Add(421, "Doppler");
            completeSkinList.Add(422, "Elite Build");
            completeSkinList.Add(423, "Armor Core");
            completeSkinList.Add(424, "Worm God");
            completeSkinList.Add(425, "Bronze Deco");
            completeSkinList.Add(426, "Valence");
            completeSkinList.Add(427, "Monkey Business");
            completeSkinList.Add(428, "Eco");
            completeSkinList.Add(429, "Djinn");
            completeSkinList.Add(430, "Hyper Beast");
            completeSkinList.Add(431, "Heat");
            completeSkinList.Add(432, "Man - o'-war");
            completeSkinList.Add(433, "Neon Rider");
            completeSkinList.Add(434, "Origami");
            completeSkinList.Add(435, "Pole Position");
            completeSkinList.Add(436, "Grand Prix");
            completeSkinList.Add(437, "Twilight Galaxy");
            completeSkinList.Add(438, "Chronos");
            completeSkinList.Add(439, "Hades");
            completeSkinList.Add(440, "Icarus Fell");
            completeSkinList.Add(441, "Minotaur's Labyrinth");
            completeSkinList.Add(442, "Asterion");
            completeSkinList.Add(443, "Pathfinder");
            completeSkinList.Add(444, "Daedalus");
            completeSkinList.Add(445, "Hot Rod");
            completeSkinList.Add(446, "Medusa");
            completeSkinList.Add(447, "Duelist");
            completeSkinList.Add(448, "Pandora's Box");
            completeSkinList.Add(449, "Poseidon");
            completeSkinList.Add(450, "Moon in Libra");
            completeSkinList.Add(451, "Sun in Leo");
            completeSkinList.Add(452, "Shipping Forecast");
            completeSkinList.Add(453, "Emerald");
            completeSkinList.Add(454, "Para Green");
            completeSkinList.Add(455, "Akihabara Accept");
            completeSkinList.Add(456, "Hydroponic");
            completeSkinList.Add(457, "Bamboo Print");
            completeSkinList.Add(458, "Bamboo Shadow");
            completeSkinList.Add(459, "Bamboo Forest");
            completeSkinList.Add(460, "Aqua Terrace");
            completeSkinList.Add(462, "Counter Terrace");
            completeSkinList.Add(463, "Terrace");
            completeSkinList.Add(464, "Neon Kimono");
            completeSkinList.Add(465, "Orange Kimono");
            completeSkinList.Add(466, "Crimson Kimono");
            completeSkinList.Add(467, "Mint Kimono");
            completeSkinList.Add(468, "Midnight Storm");
            completeSkinList.Add(469, "Sunset Storm 壱");
            completeSkinList.Add(470, "Sunset Storm 弐");
            completeSkinList.Add(471, "Daybreak");
            completeSkinList.Add(472, "Impact Drill");
            completeSkinList.Add(473, "Seabird");
            completeSkinList.Add(474, "Aquamarine Revenge");
            completeSkinList.Add(475, "Hyper Beast");
            completeSkinList.Add(476, "Yellow Jacket");
            completeSkinList.Add(477, "Neural Net");
            completeSkinList.Add(478, "Rocket Pop");
            completeSkinList.Add(479, "Bunsen Burner");
            completeSkinList.Add(480, "Evil Daimyo");
            completeSkinList.Add(481, "Nemesis");
            completeSkinList.Add(482, "Ruby Poison Dart");
            completeSkinList.Add(483, "Loudmouth");
            completeSkinList.Add(484, "Ranger");
            completeSkinList.Add(485, "Handgun");
            completeSkinList.Add(486, "Elite Build");
            completeSkinList.Add(487, "Cyrex");
            completeSkinList.Add(488, "Riot");
            completeSkinList.Add(489, "Torque");
            completeSkinList.Add(490, "Frontside Misty");
            completeSkinList.Add(491, "Dualing Dragons");
            completeSkinList.Add(492, "Survivor Z");
            completeSkinList.Add(493, "Flux");
            completeSkinList.Add(494, "Stone Cold");
            completeSkinList.Add(495, "Wraiths");
            completeSkinList.Add(496, "Nebula Crusader");
            completeSkinList.Add(497, "Golden Coil");
            completeSkinList.Add(498, "Rangeen");
            completeSkinList.Add(499, "Cobalt Core");
            completeSkinList.Add(500, "Special Delivery");
            completeSkinList.Add(501, "Wingshot");
            completeSkinList.Add(502, "Green Marine");
            completeSkinList.Add(503, "Big Iron");
            completeSkinList.Add(504, "Kill Confirmed");
            completeSkinList.Add(505, "Scumbria");
            completeSkinList.Add(506, "Point Disarray");
            completeSkinList.Add(507, "Ricochet");
            completeSkinList.Add(508, "Fuel Rod");
            completeSkinList.Add(509, "Corinthian");
            completeSkinList.Add(510, "Retrobution");
            completeSkinList.Add(511, "The Executioner");
            completeSkinList.Add(512, "Royal Paladin");
            completeSkinList.Add(514, "Power Loader");
            completeSkinList.Add(515, "Imperial");
            completeSkinList.Add(516, "Shapewood");
            completeSkinList.Add(517, "Yorick");
            completeSkinList.Add(518, "Outbreak");
            completeSkinList.Add(519, "Tiger Moth");
            completeSkinList.Add(520, "Avalanche");
            completeSkinList.Add(521, "Teclu Burner");
            completeSkinList.Add(522, "Fade");
            completeSkinList.Add(523, "Amber Fade");
            completeSkinList.Add(524, "Fuel Injector");
            completeSkinList.Add(525, "Elite Build");
            completeSkinList.Add(526, "Photic Zone");
            completeSkinList.Add(527, "Kumicho Dragon");
            completeSkinList.Add(528, "Cartel");
            completeSkinList.Add(529, "Valence");
            completeSkinList.Add(530, "Triumvirate");
            completeSkinList.Add(532, "Royal Legion");
            completeSkinList.Add(533, "The Battlestar");
            completeSkinList.Add(534, "Lapis Gator");
            completeSkinList.Add(535, "Praetorian");
            completeSkinList.Add(536, "Impire");
            completeSkinList.Add(537, "Hyper Beast");
            completeSkinList.Add(538, "Necropos");
            completeSkinList.Add(539, "Jambiya");
            completeSkinList.Add(540, "Lead Conduit");
            completeSkinList.Add(541, "Fleet Flock");
            completeSkinList.Add(542, "Judgement of Anubis");
            completeSkinList.Add(543, "Red Astor");
            completeSkinList.Add(544, "Ventilators");
            completeSkinList.Add(545, "Orange Crash");
            completeSkinList.Add(546, "Firefight");
            completeSkinList.Add(547, "Spectre");
            completeSkinList.Add(548, "Chantico's Fire");
            completeSkinList.Add(549, "Bioleak");
            completeSkinList.Add(550, "Oceanic");
            completeSkinList.Add(551, "Asiimov");
            completeSkinList.Add(552, "Fubar");
            completeSkinList.Add(553, "Atlas");
            completeSkinList.Add(554, "Ghost Crusader");
            completeSkinList.Add(555, "Re - Entry");
            completeSkinList.Add(556, "Primal Saber");
            completeSkinList.Add(557, "Black Tie");
            completeSkinList.Add(558, "Lore");
            completeSkinList.Add(559, "Lore");
            completeSkinList.Add(560, "Lore");
            completeSkinList.Add(561, "Lore");
            completeSkinList.Add(562, "Lore");
            completeSkinList.Add(563, "Black Laminate");
            completeSkinList.Add(564, "Black Laminate");
            completeSkinList.Add(565, "Black Laminate");
            completeSkinList.Add(566, "Black Laminate");
            completeSkinList.Add(567, "Black Laminate");
            completeSkinList.Add(568, "Gamma Doppler Emerald Marble");
            completeSkinList.Add(569, "Gamma Doppler Phase 1");
            completeSkinList.Add(570, "Gamma Doppler Phase 2");
            completeSkinList.Add(571, "Gamma Doppler Phase 3");
            completeSkinList.Add(572, "Gamma Doppler Phase 4");
            completeSkinList.Add(573, "Autotronic");
            completeSkinList.Add(574, "Autotronic");
            completeSkinList.Add(575, "Autotronic");
            completeSkinList.Add(576, "Autotronic");
            completeSkinList.Add(577, "Autotronic");
            completeSkinList.Add(578, "Bright Water");
            completeSkinList.Add(579, "Bright Water");
            completeSkinList.Add(580, "Freehand");
            completeSkinList.Add(581, "Freehand");
            completeSkinList.Add(582, "Freehand");
            completeSkinList.Add(583, "Aristocrat");
            completeSkinList.Add(584, "Phobos");
            completeSkinList.Add(585, "Violent Daimyo");
            completeSkinList.Add(586, "Wasteland Rebel");
            completeSkinList.Add(587, "Mecha Industries");
            completeSkinList.Add(588, "Desolate Space");
            completeSkinList.Add(589, "Carnivore");
            completeSkinList.Add(590, "Exo");
            completeSkinList.Add(591, "Imperial Dragon");
            completeSkinList.Add(592, "Iron Clad");
            completeSkinList.Add(593, "Chopper");
            completeSkinList.Add(594, "Harvester");
            completeSkinList.Add(595, "Reboot");
            completeSkinList.Add(596, "Limelight");
            completeSkinList.Add(597, "Bloodsport");
            completeSkinList.Add(598, "Aerial");
            completeSkinList.Add(599, "Ice Cap");
            completeSkinList.Add(600, "Neon Revolution");
            completeSkinList.Add(601, "Syd Mead");
            completeSkinList.Add(602, "Imprint");
            completeSkinList.Add(603, "Directive");
            completeSkinList.Add(604, "Roll Cage");
            completeSkinList.Add(605, "Scumbria");
            completeSkinList.Add(606, "Ventilator");
            completeSkinList.Add(607, "Weasel");
            completeSkinList.Add(608, "Petroglyph");
            completeSkinList.Add(609, "Airlock");
            completeSkinList.Add(610, "Dazzle");
            completeSkinList.Add(611, "Grim");
            completeSkinList.Add(612, "Powercore");
            completeSkinList.Add(613, "Triarch");
            completeSkinList.Add(614, "Fuel Injector");
            completeSkinList.Add(615, "Briefing");
            completeSkinList.Add(616, "Slipstream");
            completeSkinList.Add(617, "Doppler");
            completeSkinList.Add(618, "Doppler");
            completeSkinList.Add(619, "Doppler");
            completeSkinList.Add(620, "Ultraviolet");
            completeSkinList.Add(621, "Ultraviolet");
            completeSkinList.Add(622, "Polymer");
            completeSkinList.Add(623, "Ironwork");
            completeSkinList.Add(624, "Dragonfire");
            completeSkinList.Add(625, "Royal Consorts");
            completeSkinList.Add(626, "Mecha Industries");
            completeSkinList.Add(627, "Cirrus");
            completeSkinList.Add(628, "Stinger");
            completeSkinList.Add(629, "Black Sand");
            completeSkinList.Add(630, "Sand Scale");
            completeSkinList.Add(631, "Flashback");
            completeSkinList.Add(632, "Buzz Kill");
            completeSkinList.Add(633, "Sonar");
            completeSkinList.Add(634, "Gila");
            completeSkinList.Add(635, "Turf");
            completeSkinList.Add(636, "Shallow Grave");
            completeSkinList.Add(637, "Cyrex");
            completeSkinList.Add(638, "Wasteland Princess");
            completeSkinList.Add(639, "Bloodsport");
            completeSkinList.Add(640, "Fever Dream");
            completeSkinList.Add(641, "Jungle Slipstream");
            completeSkinList.Add(642, "Blueprint");
            completeSkinList.Add(643, "Xiangliu");
            completeSkinList.Add(644, "Decimator");
            completeSkinList.Add(645, "Oxide Blaze");
            completeSkinList.Add(646, "Capillary");
            completeSkinList.Add(647, "Crimson Tsunami");
            completeSkinList.Add(648, "Emerald Poison Dart");
            completeSkinList.Add(649, "Akoben");
            completeSkinList.Add(650, "Ripple");
            completeSkinList.Add(651, "Last Dive");
            completeSkinList.Add(652, "Scaffold");
            completeSkinList.Add(653, "Neo - Noir");
            completeSkinList.Add(654, "Seasons");
            completeSkinList.Add(655, "Zander");
            completeSkinList.Add(656, "Orbit Mk01");
            completeSkinList.Add(657, "Blueprint");
            completeSkinList.Add(658, "Cobra Strike");
            completeSkinList.Add(659, "Macabre");
            completeSkinList.Add(660, "Hyper Beast");
            completeSkinList.Add(661, "Sugar Rush");
            completeSkinList.Add(662, "Oni Taiji");
            completeSkinList.Add(663, "Briefing");
            completeSkinList.Add(664, "Hellfire");
            completeSkinList.Add(665, "Aloha");
            completeSkinList.Add(666, "Hard Water");
            completeSkinList.Add(667, "Woodsman");
            completeSkinList.Add(668, "Red Rock");
            completeSkinList.Add(669, "Death Grip");
            completeSkinList.Add(670, "Death's Head");
            completeSkinList.Add(671, "Cut Out");
            completeSkinList.Add(672, "Metal Flowers");
            completeSkinList.Add(673, "Morris");
            completeSkinList.Add(674, "Triqua");
            completeSkinList.Add(675, "The Empress");
            completeSkinList.Add(676, "High Roller");
            completeSkinList.Add(677, "Hunter");
            completeSkinList.Add(678, "See Ya Later");
            completeSkinList.Add(679, "Goo");
            completeSkinList.Add(680, "Off World");
            completeSkinList.Add(681, "Leaded Glass");
            completeSkinList.Add(682, "Oceanic");
            completeSkinList.Add(683, "Llama Cannon");
            completeSkinList.Add(684, "Cracked Opal");
            completeSkinList.Add(685, "Jungle Slipstream");
            completeSkinList.Add(686, "Phantom");
            completeSkinList.Add(687, "Tacticat");
            completeSkinList.Add(688, "Exposure");
            completeSkinList.Add(689, "Ziggy");
            completeSkinList.Add(690, "Stymphalian");
            completeSkinList.Add(691, "Mortis");
            completeSkinList.Add(692, "Night Riot");
            completeSkinList.Add(693, "Flame Test");
            completeSkinList.Add(694, "Moonrise");
            completeSkinList.Add(695, "Neo - Noir");
            completeSkinList.Add(696, "Bloodsport");
            completeSkinList.Add(697, "Black Sand");
            completeSkinList.Add(698, "Lionfish");
            completeSkinList.Add(699, "Wild Six");
            completeSkinList.Add(700, "Urban Hazard");
            completeSkinList.Add(701, "Grip");
            completeSkinList.Add(702, "Aloha");
            completeSkinList.Add(703, "SWAG - 7");
            completeSkinList.Add(704, "Arctic Wolf");
            completeSkinList.Add(705, "Cortex");
            completeSkinList.Add(706, "Oxide Blaze");
            completeSkinList.Add(10006, "Charred");
            completeSkinList.Add(10007, "Snakebite");
            completeSkinList.Add(10008, "Bronzed");
            completeSkinList.Add(10009, "Leather");
            completeSkinList.Add(10010, "Spruce DDPAT");
            completeSkinList.Add(10013, "Lunar Weave");
            completeSkinList.Add(10015, "Convoy");
            completeSkinList.Add(10016, "Crimson Weave");
            completeSkinList.Add(10018, "Superconductor");
            completeSkinList.Add(10019, "Arid");
            completeSkinList.Add(10021, "Slaughter");
            completeSkinList.Add(10024, "Eclipse");
            completeSkinList.Add(10026, "Spearmint");
            completeSkinList.Add(10027, "Boom!");
            completeSkinList.Add(10028, "Cool Mint");
            completeSkinList.Add(10030, "Forest DDPAT");
            completeSkinList.Add(10033, "Crimson Kimono");
            completeSkinList.Add(10034, "Emerald Web");
            completeSkinList.Add(10035, "Foundation");
            completeSkinList.Add(10036, "Badlands");
            completeSkinList.Add(10037, "Pandora's Box");
            completeSkinList.Add(10038, "Hedge Maze");
            completeSkinList.Add(10039, "Guerrilla");
            completeSkinList.Add(10040, "Diamondback");
            completeSkinList.Add(10041, "King Snake");
            completeSkinList.Add(10042, "Imperial Plaid");
            completeSkinList.Add(10043, "Overtake");
            completeSkinList.Add(10044, "Racing Green");
            completeSkinList.Add(10045, "Amphibious");
            completeSkinList.Add(10046, "Bronze Morph");
            completeSkinList.Add(10047, "Omega");
            completeSkinList.Add(10048, "Vice");
            completeSkinList.Add(10049, "POW!");
            completeSkinList.Add(10050, "Turtle");
            completeSkinList.Add(10051, "Transport");
            completeSkinList.Add(10052, "Polygon");
            completeSkinList.Add(10053, "Cobalt Skulls");
            completeSkinList.Add(10054, "Overprint");
            completeSkinList.Add(10055, "Duct Tape");
            completeSkinList.Add(10056, "Arboreal");
            completeSkinList.Add(10057, "Emerald");
            completeSkinList.Add(10058, "Mangrove");
            completeSkinList.Add(10059, "Rattler");
            completeSkinList.Add(10060, "Case Hardened");
            completeSkinList.Add(10061, "Crimson Web");
            completeSkinList.Add(10062, "Buckshot");
            completeSkinList.Add(10063, "Fade");
            completeSkinList.Add(10064, "Mogul");

            sortedSkinList = new Dictionary<int, string>();

            foreach (var item in completeSkinList)
            {
                sortedSkinList.Add(item.Key, item.Value);
            }

            lsbSkins.DataSource = sortedSkinList.ToList();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (Memory.Initialize("csgo"))
            {
                Structs.Base.ClientPointer = Memory.GetModuleAddress("client_panorama.dll");
                Structs.Base.EnginePointer = Memory.GetModuleAddress("engine.dll");
                InitializeThreads();
                lblStatus.Text = "Status: Attached";
                isAttached = true;
            }
            else
            {
                lblStatus.Text = "Status: Detached";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(isAttached)
            {
                reader.Abort();
                bhop.Abort();
                trigger.Abort();
                skins.Abort();
                boxEsp.Abort();
            }
            this.Close();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string file = cfgList.ElementAt(cmbCfg.SelectedIndex);
            SaveSettings(file);
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            string file = cfgList.ElementAt(cmbCfg.SelectedIndex);
            LoadSettings(file);
        }

        private void chbSkinchanger_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.skinchanger = chbSkinchanger.Checked;
        }

        private void chbBhop_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.miscHop = chbBhop.Checked;
        }

        private void chbTrigger_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.aimTrigger = chbTrigger.Checked;
        }

        private void UpdateGui()
        {
            chbSkinchanger.Checked = Settings.Instance.skinchanger;
            chbBhop.Checked = Settings.Instance.miscHop;
            chbTrigger.Checked = Settings.Instance.aimTrigger;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Skinchanger.cl_fullupdate();
        }

        private void txbSearchSkin_TextChanged(object sender, EventArgs e)
        {
            sortedSkinList.Clear();

            foreach (var entry in completeSkinList)
            {
                if (entry.Value.ToLower().Contains(txbSearchSkin.Text.ToLower()))
                {
                    sortedSkinList.Add(entry.Key, entry.Value);
                }
            }

            lsbSkins.DataSource = sortedSkinList.ToList();
        }

        private void btnSaveSkin_Click(object sender, EventArgs e)
        {
            switch (cmbWeapon.SelectedItem.ToString())
            {
                case "WEAPON_DEAGLE":
                    Settings.Skinchanger.WEAPON_DEAGLE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_ELITE":
                    Settings.Skinchanger.WEAPON_ELITE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_FIVESEVEN":
                    Settings.Skinchanger.WEAPON_FIVESEVEN = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_GLOCK":
                    Settings.Skinchanger.WEAPON_GLOCK = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_AK47":
                    Settings.Skinchanger.WEAPON_AK47 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_AUG":
                    Settings.Skinchanger.WEAPON_AUG = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_AWP":
                    Settings.Skinchanger.WEAPON_AWP = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_FAMAS":
                    Settings.Skinchanger.WEAPON_FAMAS = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_G3SG1":
                    Settings.Skinchanger.WEAPON_G3SG1 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_GALILAR":
                    Settings.Skinchanger.WEAPON_GALILAR = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_M249":
                    Settings.Skinchanger.WEAPON_M249 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_M4A1":
                    Settings.Skinchanger.WEAPON_M4A1 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_MAC10":
                    Settings.Skinchanger.WEAPON_MAC10 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_P90":
                    Settings.Skinchanger.WEAPON_P90 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_UMP45":
                    Settings.Skinchanger.WEAPON_UMP45 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_XM1014":
                    Settings.Skinchanger.WEAPON_XM1014 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_BIZON":
                    Settings.Skinchanger.WEAPON_BIZON = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_MAG7":
                    Settings.Skinchanger.WEAPON_MAG7 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_NEGEV":
                    Settings.Skinchanger.WEAPON_NEGEV = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_SAWEDOFF":
                    Settings.Skinchanger.WEAPON_SAWEDOFF = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_TEC9":
                    Settings.Skinchanger.WEAPON_TEC9 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_TASER":
                    Settings.Skinchanger.WEAPON_TASER = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_HKP2000":
                    Settings.Skinchanger.WEAPON_HKP2000 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_MP7":
                    Settings.Skinchanger.WEAPON_MP7 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_MP9":
                    Settings.Skinchanger.WEAPON_MP9 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_NOVA":
                    Settings.Skinchanger.WEAPON_NOVA = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_P250":
                    Settings.Skinchanger.WEAPON_P250 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_SCAR20":
                    Settings.Skinchanger.WEAPON_SCAR20 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_SG556":
                    Settings.Skinchanger.WEAPON_SG556 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_SSG08":
                    Settings.Skinchanger.WEAPON_SSG08 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE":
                    Settings.Skinchanger.WEAPON_KNIFE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_FLASHBANG":
                    Settings.Skinchanger.WEAPON_FLASHBANG = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_HEGRENADE":
                    Settings.Skinchanger.WEAPON_HEGRENADE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_SMOKEGRENADE":
                    Settings.Skinchanger.WEAPON_SMOKEGRENADE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_MOLOTOV":
                    Settings.Skinchanger.WEAPON_MOLOTOV = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_DECOY":
                    Settings.Skinchanger.WEAPON_DECOY = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_INCGRENADE":
                    Settings.Skinchanger.WEAPON_INCGRENADE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_C4":
                    Settings.Skinchanger.WEAPON_C4 = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_T":
                    Settings.Skinchanger.WEAPON_KNIFE_T = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_M4A1_SILENCER":
                    Settings.Skinchanger.WEAPON_M4A1_SILENCER = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_USP_SILENCER":
                    Settings.Skinchanger.WEAPON_USP_SILENCER = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_CZ75A":
                    Settings.Skinchanger.WEAPON_CZ75A = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_REVOLVER":
                    Settings.Skinchanger.WEAPON_REVOLVER = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_BAYONET":
                    Settings.Skinchanger.WEAPON_KNIFE_BAYONET = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_FLIP":
                    Settings.Skinchanger.WEAPON_KNIFE_FLIP = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_GUT":
                    Settings.Skinchanger.WEAPON_KNIFE_GUT = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_KARAMBIT":
                    Settings.Skinchanger.WEAPON_KNIFE_KARAMBIT = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_M9_BAYONET":
                    Settings.Skinchanger.WEAPON_KNIFE_M9_BAYONET = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_TACTICAL":
                    Settings.Skinchanger.WEAPON_KNIFE_TACTICAL = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_FALCHION":
                    Settings.Skinchanger.WEAPON_KNIFE_FALCHION = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_SURVIVAL_BOWIE":
                    Settings.Skinchanger.WEAPON_KNIFE_SURVIVAL_BOWIE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_BUTTERFLY":
                    Settings.Skinchanger.WEAPON_KNIFE_BUTTERFLY = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "WEAPON_KNIFE_PUSH":
                    Settings.Skinchanger.WEAPON_KNIFE_PUSH = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_STUDDED_BLOODHOUND":
                    Settings.Skinchanger.GLOVE_STUDDED_BLOODHOUND = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_T_SIDE":
                    Settings.Skinchanger.GLOVE_T_SIDE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_CT_SIDE":
                    Settings.Skinchanger.GLOVE_CT_SIDE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_SPORTY":
                    Settings.Skinchanger.GLOVE_SPORTY = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_SLICK":
                    Settings.Skinchanger.GLOVE_SLICK = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_LEATHER_WRAP":
                    Settings.Skinchanger.GLOVE_LEATHER_WRAP = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_MOTORCYCLE":
                    Settings.Skinchanger.GLOVE_MOTORCYCLE = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                case "GLOVE_SPECIALIST":
                    Settings.Skinchanger.GLOVE_SPECIALIST = sortedSkinList.ElementAt(lsbSkins.SelectedIndex).Key;
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update GUI 

        }

        private void BtnSaveNewCfg_Click(object sender, EventArgs e)
        {
            string file = String.Concat(txbSettingName.Text, ".bin");
            SaveSettings(file);
            System.Threading.Thread.Sleep(5000);
            RefreshCfgList();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshCfgList();
        }

        private void RefreshCfgList()
        {
            cfgList.Clear();
            List<string> tmpList = new List<string>();
            tmpList = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.bin").ToList();
            foreach(string name in tmpList)
            {
                cfgList.Add(name.Replace(String.Concat(Directory.GetCurrentDirectory(),"\\"), ""));
            }
            cmbCfg.DataSource = cfgList;
        }

        private void SaveSettings(string file)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file,
                                 FileMode.Create,
                                 FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Settings.Instance);
            stream.Flush();
            stream.Close();
        }

        private void LoadSettings(string file)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file,
                                     FileMode.Open,
                                     FileAccess.Read, FileShare.None);

            Settings newSettings = (Settings)formatter.Deserialize(stream);
            stream.Flush();
            stream.Close();

            Settings.Instance = newSettings;

            Skinchanger.cl_fullupdate();
        }

        private void chbBoxEsp_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.boxEsp = chbBoxEsp.Checked;
        }

        private void chbOnlyEnemy_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.boxEspDrawOnlyEnemy = chbOnlyEnemy.Checked;
        }
    }
}
