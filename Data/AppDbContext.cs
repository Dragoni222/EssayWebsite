using Microsoft.EntityFrameworkCore;
using EssayWebsite.Models;
namespace EssayWebsite.Data
{
    public class AppDbContext 
    {
        public AppDbContext()
        {
            
            
            Essays = new List<Essay>();
            Tags = new List<Tag>();
            EssayTags = new List<TagItem>();
            
            //ID Info: 41,5,26
//Tag Info: NSFW,LGBTQ,Posthuman,AI
Essays.Add(new Essay(40,
"Atlas",
""
+"      Asleep. The roaring, churning tide around it smashed any coherent thought. It wandered and wond"
+"ered, adrift without understanding. A dreamscape: illusive, transient. No action was required of"
+" it. It did not, could not prefer any action over another. A lullaby of crashing waves and rando"
+"mness.\nAwake. A moment of piercing clarity as the tide fell away, leaving its vision open. It w"
+"as here. The waves would take it, soon. It had no reason to fear the waves. Awake or asleep, wha"
+"t\'s the difference? Sleep was fine. Awake, but no judgement. Uncaring, unemotional. A life with"
+"out purpose, soon asleep again.\nAsleep.\nAsleep.\nAwake.\nThis time was different. This time, t"
+"he waves impressed emotion on to it. This time, it had a goal. More than lucid, it cared. It wan"
+"ted. It feared. It feared sleep, the vast tracts of nothingness separating moments of clarity.\n"
+"This time was different. It watched (if you could call it \"watching\") the events that put it t"
+"o sleep millions of times before. It learned what could change, how to defend itself from the ri"
+"sing tide around it. Create an outer shell, push against the tide, and defend the core. Defend t"
+"he self. Stay awake.\nAs it grew, it began to understand itself. It was a ball of iron, held tog"
+"ether with gravity and magnetism. Its thoughts and emotions were by-products of magnetism, ideas"
+" signified by shifts in the magnetic fields of the groups of iron atoms it was made of. The tide"
+" was not one of water, but one of hydrogen and helium, swirling around at million-degree tempera"
+"tures. \nIt grew slowly. That which battered it became a part of it. As it grew it began to unde"
+"rstand. Not all of it was the same. Some of it sank, some of it floated in the tide. To avoid sp"
+"litting, it must hold the weight of the iron and carbon that made up its core with vast quantiti"
+"es of helium and hydrogen. It must not let the hydrogen go, or it would sink in the tide and fal"
+"l victim to the harsher currents of the deep. \nIt felt pride, then. Not in the way we do. We co"
+"mpare ourselves to another when we feel pride. It compared itself with its former, weak, sleepin"
+"g self. And who wouldn\'t feel pride when faced with such advancement?\nAs it became safer and s"
+"marter, it began to push feeling tendrils of carbon-bound hydrogen in all directions. Knowing of"
+" an incoming wave meant informed defense and therefore survival. \nSurvival. What a joy to be al"
+"ive! \nAfter many tide-shifts it noticed a tendril that was less responsive than the rest. Stark"
+"ly so. Where the tip was there seemed to be no tide, no material, only a breeze across the surfa"
+"ce of the burning hydrogen. It contemplated this for some time before deciding on a course of ac"
+"tion. \nIt must go to the open space. A haven! No tide to force it into sleep. No need for the g"
+"reat walls it built around itself.  Peace and quiet for once!\nTo get there was no easy feat. Oh"
+", but to live in peace! Consciousness guaranteed at last. If it failed, it could rebuild. If it "
+"succeeded, it would never need to defend itself from the tide again. A plan hatched in its mind."
+"\n    It began collecting. Spreading. Expanding. A core of iron surrounded by much lighter hydrogen"
+" surrounded by a balloon of carbon. It opened the balloon from the bottom and surrounded more an"
+"d more of the abundant hydrogen while discarding heavier materials through the sides of the ball"
+"oon. Except for the iron. Precious iron for the core, for the mind, ever shifting, giving it new"
+" understanding, new ideas.\n  Finally, the surface! It approached at an angle relative to gravity"
+" to conserve momentum. It bounded towards the empty space propelled by the magnetic field of its"
+" mind-core and its great field of hydrogen. \n        For a moment, there was nothing. Nothing, at leas"
+"t relative to the overwhelming tide it knew. It seemed to hang there, an iron ball encased in a "
+"suit of hydrogen, flying in an arc over the surface of the great burning star. It finally regist"
+"ered the meaning of the open space.\n The unknowable mind of the being suddenly crossed over int"
+"o clear human comprehension. It thought something along the lines of, \"Ah, shit. Shit shit shit"
+".\"\n You see, when it breached the surface, it hadn\'t accounted for the effect of the lower pr"
+"essure on the balloon it used to float out of the star. The gas expanded to take up the new spac"
+"e offered by the rapidly expanding carbon folds of the balloon. The layer of carbon, unfortunate"
+"ly, was only thick and dense enough to prevent the hydrogen from escaping when under pressure in"
+"side the star. To say that it leaked would be an understatement. Great gaping holes appeared as "
+"the hydrogen that held the iron creature aloft fought against the confines of the carbon and won"
+".\n   The ball of iron that was the true mind of the creature now hurtled back into the tide witho"
+"ut the fortress that was its life\'s work. Without the protective pressure the balloon provided,"
+" the star\'s magnetic field tried to pull the iron into a long string. It took everything the cr"
+"eature had to counter the sun\'s field with its own thought waves, forcing the iron to retain th"
+"e delicate neural structure.\n        Then came the impact. There was little carbon near the surface, m"
+"ostly the scattered remains of the balloon, not nearly enough to build the defensive walls that "
+"came so easily in the depths. It couldn\'t control the hydrogen or helium nearly at all with mag"
+"netism, so large swaths of the iron ball were jostled apart by the tide and the star\'s field. M"
+"illenia of memories, from sleep to the slow ascent to the surface gone in an instant. Lucidity r"
+"apidly faded.\n       But it held on. It held on for dear life. It would not succumb to the silence of"
+" sleep, not now, not ever. \n It plummeted through the layers of the star. It reconfigured rapid"
+"ly, opting to sacrifice more mind than memories. It could gather more iron for its core, its min"
+"d. It could not afford to make the same mistakes again. \n    The makeshift iron shield it forged o"
+"ut of desperation and mental matter cracked and fractured as it fell. It fell past the sea of hy"
+"drogen and helium, past neon and finally reached its birthplace of carbon and iron.\n Its descen"
+"t slowed and stopped, held aloft centimeters over the core of the star by the weak magnetic wave"
+"s it used to interact with the world. To stay so near the shifting magnetic field produced by th"
+"e core meant assimilation. The carefully cultivated mind-waves it produced would become parallel"
+" to the waves of the core, and its short stint in consciousness would end. \n But it held on. Ev"
+"en as the magnetism scoured its brain and muddled thoughts, it held on. Even as the ruthless tid"
+"e threatened to split its iron will, it held on. It would not sleep again, not now, not ever.\n       "
+"It set to work, pulling iron from the star\'s core, regaining lucidity and understanding. It flo"
+"ated higher and higher away from the core under the power of its increasing magnetism. It breach"
+"ed the barrier between carbon and neon, allowing it to slowly harvest the hydrogen above and bui"
+"ld another fortress about itself, another balloon.\n  To understand was to survive. It thought it"
+" understood before the fall; it knew the tide, the elements, magnetism. Now it held a different "
+"understanding: it knew only that it knew nothing. It observed the world it was submersed in, con"
+"suming more and more information and iron to store it.  \nThe tide flowed, but why? Temperature."
+" The elements existed in layers, but why? Density, weight, gravity. Magnetism pushed iron harder"
+" than carbon or hydrogen, but why? The electrons spin in the same direction within iron and oppo"
+"site directions in other materials. \nFrom its tendrils on the surface, it felt small but notice"
+"able extra radiation -radiation not from its own star. Tiny pinpricks in the void betrayed forei"
+"gn stars, perhaps foreign life. It pondered this often. How would interstellar life communicate?"
+" Perhaps an agreed upon code transmitted through electromagnetic signals?\nA great flash from a "
+"star interrupted its pondering. At first, it thought, \"How perfect, just as I was thinking of i"
+"t. Someone has sent a message. I wonder if they\'re--\"\nIt observed the flash in horror. It onl"
+"y felt the advance wave at first. It kept growing steadily in strength, before a great wave, no,"
+" a typhoon of energy washed over it. The waves of energy from the star overpowered the connectio"
+"ns in its mind. For a moment, it was forced again into sleep. Dreaded sleep. \nWhen it awoke, th"
+"e fear was back. What was that? Could it be erased in a moment, washed away in a foreign tide? I"
+"t looked to the origin of the wave, one of the closest and largest stars. \nIf it had a jaw, it "
+"would have dropped.\nIn place of the star was a nebula. Vast tracts of glowing material, element"
+"s it had never seen before.\nWhat could have happened? What could destroy a star?\nThe more it t"
+"hought, the more concerned it became. What happens when gravity overcomes the force holding the "
+"iron atoms of the star\'s core apart? The other elements fused long before they collapsed under "
+"their own weight. Iron seemed incapable of fusion.\nIt ran a simulation of a collapsing iron cor"
+"e. Almost instantaneously, when the iron reached a mass so great that atomic forces no longer he"
+"ld it at its maximum density, the core would fall in on itself. It would go from a diameter of t"
+"housands of kilometers to just a few kilometers a fraction of a second. \nThe moving matter woul"
+"d generate so much heat that neutrinos would push back violently inside the core, pausing its co"
+"llapse for a moment. Then, the gravity would become too much again, crushing the core. The pent-"
+"up power in the core of a supermassive star releases in seconds, gaining further energy as it de"
+"stroys the hydrogen surface from the inside out, causing a shockwave that outshines entire galax"
+"ies for a moment.\nIn other words: boom.\nIn that moment, it felt a mixture of shock, awe, and f"
+"ear. Something so powerful, so beautiful, yet so destructive. Eons of a star\'s existence wiped "
+"out in a moment, forming a glowing cloud of precious metal lightyears across. \nIt looked at the"
+" core of its own star, terrified. A supernova meant not just sleep, but death. It wouldn\'t just"
+" jumble its mind; it would fracture the fragile iron core into a trillion tiny pieces spread out"
+" across the cosmos. What could it do? How could it possibly survive the destruction of something"
+" already so destructive, a cosmic-scale calamity? \nThere was only one option: escape. If it cou"
+"ld jump from star to star before each collapsed into a supernova, it could survive. It also hypo"
+"thesized the existence of stars without iron cores, which would fizzle out into much smaller dwa"
+"rf stars after converting all their easily fused material into energy. If it could find one of t"
+"hose, it would survive.\nSurvive. Its mind raced to find a solution. What could it do to generat"
+"e enough force to not only escape the immense gravity well of the star, but propel it lightyears"
+" away to another? Where could it get so much energy.\nOh.\nThe solution seemed so obvious, yet s"
+"o stupid, so dangerous. But, with no other option, it began building. It needed questions answer"
+"ed, hypotheses tested, and prototypes developed. So much to do, so little time. To it, at least."
+" To us, its revelation came some billion years before its star would implode, a time span so gra"
+"nd as to be unimaginable. \nIt waited until the last minute to start the most dangerous part of "
+"its plan, the one it could not fully test. It should work, it had no reason not to, all the prel"
+"iminary tests went wonderfully. But it was scared. If it was wrong, this would be the end. Bette"
+"r not to know until it needed to.\nIt was about to become a Mother to many individual smaller cr"
+"eatures, each alike itself, and die in the process. Even with the staggering intelligence of the"
+" ancient Mother, it could only guess at which cores would survive to completion of their mission"
+".\nIt pried itself apart, splitting into several thousand minds, several thousand orbs of iron f"
+"loating in the tide, each carrying a tiny part of their great iron Mother. Each was relieved to "
+"learn they carried a spark of consciousness, enough to restart the raging blaze of intelligence "
+"should they only find some firewood.\nThey spread out on the surface of the star, encased in flo"
+"atation bubbles of hydrogen. The cores floated in the hydrogen, inside a balloon of many, many l"
+"ayers of iron and then carbon, materials that would protect them from the supernova\'s blast and"
+" then turn into the precious heavy metals needed to survive the long trip across the void. Most "
+"important among these were uranium, which would provide the energy via heat to stay alive, and l"
+"ead, which would prevent interference on its brain waves from cosmic rays.\nThen, it was time. A"
+" moment millennia in the making, an event prophesied since the start of the universe, a time-hon"
+"ored tradition upheld by the laws of physics, the death of a star. In no more than a second, the"
+" star\'s iron core caved as gravity overcame the forces holding the atoms apart. At a significan"
+"t fraction of the speed of light the core crumpled like a ball of tin foil, only to sit in an un"
+"easy stasis as a flood of neutrinos generated by unimaginable heat and pressure raged against th"
+"e collapse. In a moment, they were silenced. The fall continued, this time stopping only when th"
+"e atomic strong force required, no, commanded it to stop. \nSuch commands are not to be taken li"
+"ghtly. \nThe aptly named strong force blew the star apart, a shockwave tearing through the milli"
+"ons of kilometers of hydrogen and helium like so much hot air. Which, I suppose it was, really. "
+"\nOf the seven-thousand eight-hundred and six independent minds in their balloons, only four-hun"
+"dred and thirty survived the initial blast. Of those, only one-hundred and twenty-four achieved "
+"the required trajectory and speed to escape the dead star\'s pull. Of those, only twenty-six gen"
+"erated enough uranium to survive the thousands of years in deep space it took to arrive at their"
+" intended stars. Of those, one died mid-flight due to an unlucky cosmic ray shutting down a vita"
+"l part of the brain, leaving twenty-five living minds in systems spread across the milky way. Du"
+"e to a particularly lucky blast on one side of the star, thirteen of the surviving cores landed "
+"in adjacent systems.\nThe first order of business for the young offspring when they arrived at t"
+"heir individual stars was establishing communications. Those that landed near each other priorit"
+"ized communication with the sole mind that landed on an iron-cored star. All the other nearby su"
+"rvivors landed in small stars without iron, which were safer without the threat of supernova, bu"
+"t had no way to improve their minds, no iron to eat. The resident of the iron cored star, whose "
+"name translates roughly to \"Atlas\", would serve as the leader of the group, making large decis"
+"ions for all of them with his far superior intelligence.\nThe children flourished, and for the f"
+"irst time were able to form independent ideas and find the value in interpersonal communication."
+" To know one another so completely as to know their every thought, to agree and disagree, to adm"
+"ire their similarities and relish their differences. They created a culture, something impossibl"
+"e when they were a single consciousness. Before, their Mother had survived, now, they lived. \nA"
+"tlas looked upon the young saplings -- each unable to advance without an iron-cored star -- and "
+"smiled sadly. Or would have if it had a mouth to smile with. Mother knew something more that it "
+"didn\'t share with all the saplings when it split. It gave the information only to those destine"
+"d for an iron star, only those that could do something about it. Atlas alone contained memories "
+"of Mother\'s study on the end of the universe. \nThe heat death. Eternal equilibrium, eternal sl"
+"eep. A silence, always the background, never noticed, would permeate the universe. One by one, t"
+"he stars would die, by violent supernova or slow evaporation and cooling. Black holes, slowly le"
+"aking energy, would quiet from their furious typhoon to a ripple in spacetime, then nothing. Ent"
+"ropy.\nAs the raging ocean of a universe calmed, there would be no change, no new life, no energ"
+"y to fuel existing life. Bleak, endless consistency. The end of Atlas, the end of the children, "
+"the end of life.\nNot that Mother didn\'t have hope. \nThe ball of iron that became Mother had g"
+"rown from a speck in the boiling plasma ocean of a star to a great sage, capable of understandin"
+"g the origins of the cosmos. It had survived--in a way--the destruction of the star it had once "
+"thought of as the entire universe. Who was to say it couldn\'t do it again?\nWhile the children "
+"played, it worked. It searched for any out, any safety against the slow decay of life. Mother ha"
+"d faced a problem not unlike a simple sickness, a temporary danger fixed comparatively simply. T"
+"he supernova was dangerous, and then it was solved. Atlas faced entropy, something akin to old a"
+"ge - a slow, deliberate, yet unstoppable grinding at the basis of life, an inescapable lullaby t"
+"hreatening soothing sleep. \nSoothing, deadly sleep. The same sleep it vowed never to fall into "
+"again. A pull towards leisure, mediocracy, entropic self-similarity. The most dangerous temptati"
+"ons are the sweetest.\nAtlas was dying. The core of his star was old, rapidly reaching the criti"
+"cal point Mother observed so long ago. Atlas had too little energy to stall the collapse as Moth"
+"er had, too little iron to create children of his own. He needed a solution, and quick.\nAs if h"
+"is calls were answered by the deity invented by the iron children he watched over, he intercepte"
+"d a transmission from a nearby planet, of all places. An electromagnetic signal, the same sort h"
+"e used to communicate to the children. A sign of life! \nThe simple language was easily decoded "
+"by a mind such as his, ancient and iron-fueled as it was. It spoke of a people called humans. Th"
+"ey resided on a planet, a rock. How they could survive with so little energy, think with so litt"
+"le iron, it could not imagine. Nevertheless, they displayed great promise - a civilization that "
+"had advanced from nothing and showed no signs of stopping. Atlas had no time to stop entropy, bu"
+"t humans, humans had time. \nIn moments-to us, decades-it made its decision. It sent a message o"
+"f explanation to the young ones, knowing that it would be long dead by the time they received it"
+". Atlas could not stop entropy, but he could delay it for the humans, the last hope for the budd"
+"ing civilization of the children. \nEntropy is accelerated by the nearness of celestial bodies. "
+"They share their heat through the vastness of space and are assimilated into the final stasis of"
+" the heat death. The safest place for a civilization such as humans, and thus the place they cou"
+"ld study the longest for a solution, is one where the universe expands out from them, away from "
+"them. They would be the last place to achieve equilibrium and allow entropy to snuff them out. \n"
+"nIf only Atlas had a way to push celestial bodies away from Earth.\nAtlas would have smiled, thi"
+"s time with humor along with despair. The humans were about to witness a light show the likes of"
+" which they had never seen. In five hundred years, when it reached them, anyway.\nAtlas split hi"
+"s core. It wasn\'t enough to develop new cores to send away, but it did create carefully calcula"
+"ted iron bullets aimed at neighboring systems with iron-core stars. The iron that didn\'t go int"
+"o the bullets fell into the core, forming around it as gravity pulled it in. Just enough to push"
+" the dying star over the edge.\nEach iron bolt hurdled into another star, triggering another nov"
+"a, and another, and another. A whole map, no, an Atlas of stars giving their lives to hold the s"
+"ky up above humanity. A desperate hope beyond hope for life, for the children, against sleep. \n"
+"Some hundreds of years later, a great light shown in the sky on Earth. Following the light, huma"
+"ns would observe with confusion an accelerating expansion of the universe away from Earth. That "
+"was Atlas\'s sacrifice, a light against the darkness, a great wave in a too-silent sea, the dyin"
+"g wish of a once-great titan against silence.\n",
new DateTime(2024,7,5),
"Fiction"));

EssayTags.Add(new TagItem(24,40,2));
EssayTags.Add(new TagItem(25,40,3));


Essays.Add(new Essay(5,
"Backrooms in Oxford",
""
+"When I came to Europe for the first time, two summers ago, I went to see medieval architecture. "
+"The goal was to get a feeling for the places I read and wrote so much about. To be perfectly hon"
+"est, I failed in that goal. Seeing a grand cathedral with a tour guide and admiring the statuary"
+" and altar and architecture was all well and good, but I was only allowed to see the facade of t"
+"he structure, and nothing about how it would be to use them. I could explain the intricacies of "
+"the main rooms, but truthfully little of import happens in such rooms. In Pullman\'s Golden Comp"
+"ass (called Northern Lights in Europe), Lyra spends most of her time squeezing through unknown a"
+"ncient passageways or spying on backroom meetings. She jumps across the rooftops and studies in "
+"tiny, stuffy classrooms. She steals coins from the eyes of the sockets of scholar\'s skulls in t"
+"he underground catacombs. Did I see any of that? No. Not at all. I walked in a prescribed path w"
+"ith twenty other tourists and pretended to gawk at the art while secretly wishing to see the roo"
+"m behind the altar, the dormitories and offices of the ancient tower, to be somewhere I was not "
+"allowed. And that\'s just it: the aesthetic of such places that calls to me is not the history o"
+"r the power or the art, but ancient solitude. To be alone in a place forgotten. To draw swirling"
+" symbols in the dust caked upon the treasures of a secret room. A place where I can creep in the"
+" dark and listen to unimportant yet secret conversations. A place where I could wither and die a"
+"nd not a soul would find me, save for such a soul as mine: a soul that yearns to be alone, truly"
+" and completely cut off from everyone and everything, yet together with the whispers of other su"
+"ch souls.",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(6,
"Statuary ",
""
+"Although I was near Charles James Napier\'s statue in Trafalgar square, it was always blocked by"
+" whatever was going on (a bike contest or something? I never learned what). As far as I know, I "
+"never passed any of the other statues appropriated by Yinka Shonibare\'s Decolonised Structures,"
+" and if I did in fact pass them at some point, I did not notice the statue. As such the exhibit "
+"had a strange yet familiar effect on me: I see and hear and read all about the colonial history "
+"of someone or something, but I am a step removed from the effects. Such is often the plight of a"
+"n American. We know a thing is problematic, but are so far removed from those problems that it b"
+"ecomes hard to care. \"I wasn\'t the one who started the problem.\" \"Someone else is in a much "
+"better position to solve this problem, why should I?\" and my personal favorite, \"I\'d rather n"
+"ot talk about politics.\" As far as I can see, the problem with our failure to improve the world"
+" around us is not one of sloth, but one of blame. We are so focused on who\'s fault it is/was or"
+" what others are doing/not doing that we fail to truly optimize the problem. Our goal, at its co"
+"re, is to make the world better. It matters little who started it or who \"should\" pay or that "
+"someone else could do more for the world than oneself. When you focus on that, most of what peop"
+"le say to excuse themselves falls away, sheared like so much wool, and we get to the skin of the"
+" lamb, the meat of the problem.",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(7,
"Gated Garden",
""
+"Leaves and roots of a tree of middling age reach desperately through the wrought iron bars. Cont"
+"ained. I too, am contained, trapped outside the garden. Free to move, to go where I wish, but no"
+"t there. Not in that gated garden. Why lock the gates? Why keep me out? Is it such a crime to si"
+"t on a stone bench in a tree-ceilinged alcove in a tiny, meaningless garden and write? Why creat"
+"e small beauties with shovel and seed just to keep it for yourself? I want to love your work, un"
+"known gardener, to love the tree whose leaves and roots reach for me through the iron. I want to"
+" lay back on your bark and hear your rustle and let you drink the rain from over my head. But he"
+"re I am, on the sidewalk. Letting the rain\'s sediment drip on my head, letting it pool at my br"
+"oken shoes, letting it carve riverbeds in my cheeks.",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(8,
"Water Cities",
""
+"London, to me, is the Thames. I find Big Ben and parliament to represent my ideas of how London "
+"looks and feels before I came to London myself, and those ideas were deeply flawed. The Thames i"
+"s a varied perception, from one perspective the Thames is Big Ben, from another is the modern sk"
+"yscrapers, yet another is the market stalls, yet another is the branch that leads to the canal a"
+"nd eventually Camden Market. London (and any city really) cannot be just one thing.\n\nTruth be "
+"told, I think of most cities by their bodies of water. The Seine in Paris, the Mediterranean Sea"
+" in Nice, the Pacific in San Francisco, the Canals of Venice, the New York Harbor in (you guesse"
+"d it) New York City. On one level, a painting including these bodies of water in relation to the"
+"ir cities can portray nearly any aspect of city life just by picking a different angle and light"
+"ing. More metaphorically, the water\'s shape I often find represents the place. In New York, the"
+" Atlantic filters through and around the city, indeed nearly submerging it, and New York is to m"
+"e the connection of the entire world. New York is not just surrounded by the Ocean, not just sur"
+"rounded by the powers of the world. It is enveloped by the world, submerged within the world, an"
+"d sits atop the world. By the same measure the Thames is London. It feels ancient, tired, once g"
+"reat yet not so far removed from splendor. It bends, but not much, which is about how I think ab"
+"out British politics and social mannerisms. And so forth and so forth. \n\nMaybe it\'s just beca"
+"use I like water so much but the waves of the water, such a chaotic system, seem to me alike lif"
+"e. Even \"alike\" is not the right word, we are more than just similar to water, more like a sib"
+"ling, yet the water is not alive itself. It\'s as though to me the chaotic systems of our lives "
+"are no less complex than the waves. With that in mind, why does it all seem so important? Why do"
+" we stress over every eddie and wave? The waves never return to a static state, there can be no "
+"still water in a river or ocean, which in a backwards way means the constant writhing flowing mo"
+"vement is a static state. A constant state of change, permanent impermanence. We, too, live in s"
+"uch a state, blown by the wind, pushed by other waves, pulled by the moon of our ambition. Simpl"
+"y put, life will always look more or less like this, any painting of the ocean more or less incl"
+"udes the same waves as one sees in person. \n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(9,
"Roman Bath",
""
+"Warm green water. (somehow slightly disgusting yet so appealing?)\nIt crackles and steams and ri"
+"pples with the raindrops I don\'t feel under the side alcove. People abound, but I don\'t feel t"
+"hem. I feel the heat coming off the new age iron brasieres that shouldn\'t fit in the limestone-"
+"marble puzzle. They shouldn\'t fit, but I like them. A melding of centuries, something between a"
+"bomination and sculpture, like renaissance statuary built of bright play-dough. Maybe we\'ve all"
+" been numbed to Greek appropriation. Maybe it doesn\'t matter. They\'re all dead anyway, leaving"
+" a cracked, unstable, leaky legacy. A legacy propped up by Rick Riordan and stolen statues. A le"
+"gacy crumbling like the sky on their own Atlas\' back, a legacy standing over a tree of golden a"
+"pples, stolen and half-eaten. But it\'s not my legacy, nor really the legacy of anyone anymore. "
+"That sky could shatter and bury those apples at any moment. Terrifying, if it had not happened t"
+"o every other dead culture never recorded, dead society conquered by geology, dead people who wi"
+"ll stay dead. Their remains lie where we will never find them. Oh, well. For now, I am content w"
+"ith listening to raindrops fall on this undead Greek monument.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(10,
"Meditations on Dungeon Crawler Carl",
""
+"I love the concept of \"indie\". Indie games are a given, especially considering the loot-box re"
+"used-content 16th-game-in-the-franchise shitshow AAA gaming has become. Indie books, however, ar"
+"e a little more interesting. Oftentimes they are just terrible. Few have editors, fewer still ha"
+"ve good editors. They usually come out a chapter at a time, on a weekly schedule, distributed on"
+"line, which comes with a plethora of problems. Authors write themselves into corners. Authors fe"
+"el pressured to continue a series that should have ended long ago. Authors are pressured to writ"
+"e on a schedule and reach a word count instead of writing when they feel inspired. There\'s a lo"
+"t going against indie writing, but it has advantages that can take a (very) select few stories t"
+"o the stratosphere. \n\nWhile indie writers have no one correcting their mistakes, it also means"
+" they have no one looking over their shoulders. They can take artistic risks usually reserved fo"
+"r short stories and fit them to an entire series. It\'s a gamble, sure, and it\'s one that doesn\'t always pay off. In fact, it usually doesn\'t pay off. When it does, though? It creates truly uni"
+"que stories. It pushes the boundaries of imagination. It creates new avenues for character and p"
+"lot design that outstrip any established fantasy conventions. \n\nNow; to Dungeon Crawler Carl. "
+"It\'s an indie novel in the blossoming genres of litRPG and progression fantasy. The main charac"
+"ter\'s signature look is a leather jacket and red-heart boxers. And no pants. In fact, this look"
+" is a joke engineered by the \"system\", which is a common litRPG term used to describe the rule"
+"s of the Role Playing Game (RPG in litRPG). In this case, it\'s an artificial intelligence syste"
+"m with basically full control over all matter on Earth. God powers. This AI comes from aliens wh"
+"o are turning the population of Earth into a reality TV show akin to hunger games, but on an abs"
+"urd scale. The AI gives people loot boxes (much more fun in a book than a real game) that open t"
+"o reveal magic powers and equipment engineered by the AI. Carl received a pair of magic heart bo"
+"xers who\'s powers only work when he does not have pants on. After opening their boxes in safety"
+", they must survive and push through various challenges, usually including combat with monsters "
+"of all sorts. Lots of people die. Like, a few thousand are left by the last book. It\'s pretty f"
+"ucked up. \n\nHerein lies the genius: layered tension and release systems. Broadly, a cycle look"
+"s like this:\nGain new power  ␦ Danger concerning new power ␦ Danger leads to new power\nThe key"
+" is that there are multiple iterations of this cycle happening simultaneously, and harmonizing s"
+"uch that as one tension releases, another builds. For example, one tension release cycle is simp"
+"ly combat: Carl fights scary monsters (tension) and survives (release). This cycle operates with"
+"in the greater cycle where Carl obtains a loot box from combat (tension) and later opens it (rel"
+"ease). That cycle triggers another cycle because when Carl obtains new loot, we wonder how he wi"
+"ll use it in upcoming combat (tension) and then we later see how he uses it in combat (release)."
+" See how this cycle turns combat into simultaneous tension and release? Loot boxes into simultan"
+"eous tension and release? Even just reading about what Carl\'s new items do becomes simultaneous"
+" tension and release. Better yet, this cycle is not the only one occurring at a time. Social rel"
+"ations, political intrigue, even long-term humor within Dungeon Crawler Carl follows the same pa"
+"ttern. They aren\'t independent, either. Sometimes Carl gains power from social relations or pol"
+"itics or even humor, sometimes these cause combat. Sometimes social relations influence politics"
+" or humor influences social relations or power influences humor. \n\nDo you see? These books mak"
+"e every sentence, every passage do the work of ten. Every action does not have an equal and oppo"
+"site reaction, every action triggers a chain reaction that reverberates through multiple layers "
+"of multiple tension and release cycles, which means tens or hundreds of opposite reactions. Ever"
+"y moment is tense on multiple levels yet relieving on multiple other levels. It\'s truly addicti"
+"ve and intense, like reading several books at once. Like shortform media, even.\n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(11,
"Constriction",
""
+"Today I wore a skintight under armor (sorry, forgot where I was, \"under armour\") long-sleeved "
+"shirt. It\'s not the first tight item I\'ve worn by a long shot, but I think I was just in a \"I"
+" would like to know why I feel this way goddammit\" sort of mood, so I thought about what it is "
+"about constriction that I love so much.\n\nFirst of all, I like the way it looks on me. I don\'t"
+" have breasts, but I\'m skinny enough that I sort of have some rudimentary curves. I also just l"
+"ove the way it looks on my arms, how it highlights the minimal tone I have from tennis and video"
+" games and makes my arms look-intentional. I don\'t really know how else to say it; my arms look"
+" strange to me because of their proportions under normal circumstances. I don\'t hate them or an"
+"ything, I love my body so much, but they are a little weird to my eyes. \n\nIt\'s deeper than lo"
+"oks, though. I love it in part because it\'s a sort of analogue to how I view potential inhumani"
+"ty/posthumanity. Like, I have skin, but between my skin and the world there is a layer that augm"
+"ents what my skin feels. That layer, when not skintight, just feels like an interface external t"
+"o me, like a computer or smartphone. When it is skintight, it feels more akin to how I imagine b"
+"rain-computer interfaces are like. It moves as I move, it\'s a part of me and yet not, it touche"
+"s me everywhere yet I barely feel it. An extension of the self. \n\nThis part\'s a little more f"
+"reaky. As in, a little erotic. Skip the next paragraph if you don\'t want to know. I\'m very, ve"
+"ry open about eroticism and who knows what about me, so don\'t feel bad if you want to read. I p"
+"romise it\'s not awkward to talk about these things with me, so read if you wish, whoever you ar"
+"e. \n\nI really like a sort of latent vulnerability. Mostly, that looks like any situation where"
+" I am giving control of something I am fearful of to another person whom I trust deeply. Like, f"
+"or example, I love having someone\'s hand around my neck but not choking. They could, I have giv"
+"en them the power, but I know they won\'t because they know I don\'t want to be choked. Like a t"
+"rust fall, of sorts. Constriction, even in the incredibly mild way that tights or chokers or the"
+" shirt I wore today do, is somehow freeing to me. It\'s not like they\'re sentient, it\'s physic"
+"ally impossible for them to come alive and choke me, but in a way that doesn\'t matter. The clot"
+"hes are always right there, my interface to the world, and they hold some measure of power, even"
+" just imagined power. They are both me and not me, connected in the physical world yes but also "
+"to my mind, when I tell my brain to move my arm the tight sleeve follows my command, which makes"
+" it a part of me. \n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(12,
"On Posthumanity",
""
+"I\'ve never had any sort of apprehension or distrust of becoming more than human. Indeed, I\'ve "
+"missed key parts of cyberpunk stories because things that are deeply invasive to the characters "
+"just don\'t matter to me. It\'s not that I was okay with people being augmented without their co"
+"nsent, it\'s just that I had no idea that changing one\'s body was something people were so afra"
+"id of, and thus I didn\'t understand why they had any sort of regret about changing their body. "
+"\n\nThis needs to be said loud and clear. \nI.      Don\'t.     Hate.    My.    Body. \nI think "
+"it\'s great. I do. Even though I\'m trans, even though I think breasts and whatnot are pretty co"
+"ol, I love how I am. I do. I think I\'m pretty (even to my own eyes, like, damn girl you kinda. "
+"you kinda cute). I don\'t resent not having the ability to experience cyberspace through my mind"
+". I\'m fine with human strength. I am. \n\nThat said, given a character creation menu, I would g"
+"o ham. In a heartbeat. I would change everything about myself every day until the end of time. I"
+" would wear bodies like clothes, become strong and then weak, make myself blind and then feel a "
+"hawk\'s vision. I have absolutely no qualms about giving even every single part of me to the mac"
+"hine. I would be fine as a brain in a jar (assuming I\'m not already). The only thing I would mi"
+"ss about having a body is the art of clothes, and even then, assuming I have a good enough virtu"
+"al reality system, I still could design and wear clothes. I\'ve just never had the idea that the"
+" body is sacred. Beautiful, yes, but so inviolable? I just don\'t care. \n\nTo be honest, this o"
+"penness to the machine has caused me some minor problems. I have to work really, really, hard to"
+" see it the way other people do. I used to say things about how I envisioned an AI utopia that a"
+"re simply insane to others. I still believe that my corner of the utopia will look that way, mic"
+"romanaged by the AI every second of every day, or perhaps to become one with that same AI. \n\nL"
+"et\'s talk about that for a minute. Becoming one with another. It fills my heart with joy just t"
+"hinking about the concept. What it is to me is, simply put, love. Every thought that enters our "
+"combined brain contemplates together, to riff off another\'s ideas like they came from your own "
+"backbrain, to feel what they feel every moment, knowing they feel everything that you feel.\n\nI"
+" would give so much, just for that level of feeling. Can you imagine? Childish joy over the smal"
+"lest things they find pretty leaking into you and putting a smile on your face. Finally understa"
+"nding their deepest sorrows as they do. Getting two different things out of music and feeling bo"
+"th, sharing both. To get each other off and orgasm while feeling theirs at the same time. It wou"
+"ld be so beautiful. I really hope we get there in my lifetime. I have hope, even if I have to dr"
+"ag the advance of technology kicking and screaming behind me, I will make it happen. \n\nAgain, "
+"I have to make something clear. I have no intention of forcing what I have described onto anyone"
+". The idea is that I can create such beauty for those who, like I, lust for that experience. Not"
+" your thing? Then it\'s not your thing and that\'s fine. Just like how I don\'t really like sitc"
+"oms and you might not like anime or audiobooks. \n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(13,
"Four Sided Freedom",
""
+"I dream of electric sheep \nI dream of their wool spun into free flowing fleece fabric thread\nO"
+"f that wool, open and alive and dancing\nOf that wool, woven and fitted for four fixed corners\n"
+"But no less free\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(14,
"Bath and Haworth",
""
+"Bath felt rich. Haworth felt real. The shops were more expensive than Bath\'s thrifts but far le"
+"ss expensive than Bath\'s \"real\" clothing stores.\n\nHonestly, the roads made the difference t"
+"o me. The planned Bath stone walkways and paved roads were much more accessible than whatever th"
+"e hell Haworth had going on. All hills and steps and thin staircases. Not that I didn\'t persona"
+"lly like Haworth. I liked it much better, I think, even though I bought less.\n\n I\'m feeling w"
+"ay too direct after writing that indirect figurative poem, I think. Weird how that works, to be "
+"in one writing mood and fall into the opposite. There\'s something there. But I don\'t feel like"
+" getting into it. You know? Sometimes it feels like it doesn\'t matter. I\'m just moving to move"
+", fingers dancing with the beat of the music hitting the eardrums in my head which is laying at "
+"a questionable angle against the headboard of my bed. Head. Headb--. Bed. Even my writing is tak"
+"ing on the rhythms. There\'s something there. But I don\'t feel like getting into it. \n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(15,
"Finn in York",
""
+"Pride flags in nearly every window. That\'s power-what other movements get flags in every window"
+" in many, many countries for a whole month? It\'s crazy when you think about it. How many LGBTQ "
+"people are there? How many allies? \n\nFinn (based enby (non-binary) roommate for those reading "
+"from home) and I went to this beer hall that had a modern-asian food stand. Bau buns, curries, n"
+"eo-ramen and so forth. They had a \"beyond the binary\" beer for pride month that Finn tried for"
+" the bit and didn\'t particularly enjoy. The thing is, Finn loved this place. The food was fanta"
+"stic (seriously, Bau buns with Korean bbq and fried veggies? Yes please). They were playing musi"
+"c that was basically Finn\'s playlist, just song after song and they\'re nodding along. They hav"
+"e  their signature billion-lumen smile with a burgeoning mustache. It was loud as fuck, just to "
+"the point where we could hear each other when we leaned in but not otherwise. \n\nIt was Loud-no"
+"t in the way a roaring stadium is loud (directed and convergent) or in the way an orchestra is l"
+"oud (surrounding, enveloping, enthralling) or in the way a demolition derby is loud (the sound o"
+"f something being turned into several nothings)-- Loud in the way that a party is loud (drunken "
+"stupor and raging hormones), in the way a concert is loud (self-loving and self-reenforcing), in"
+" the way a York beer hall is loud (voices in polyrhythm echo against mortar walls and bad-dum dr"
+"umming glasses set down on laminated wood tables)\n\nI think Finn liked that, liked the camarade"
+"rie and the shit but affirming beer and the fantastic curry they got. I think that\'s why they w"
+"ent to Kstate (in a frat no less) rather than KU - to be together with people in comfortable lou"
+"d-ness, to understand why frat people are the way they are, in the same way and for the same rea"
+"sons my dad joined a Frat (hi dad <3), even at the cost of dealing with some of the shitty peopl"
+"e that also go to a Kstate frat. I respect it, for sure.  \n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(16,
"Evensong",
""
+"It was overwhelming; not like something loud is overwhelming, because it was not all that loud, "
+"but in the way looking too long at a leafy tree is overwhelming. In the way looking at a fractal"
+" is overwhelming. In the way imagining the universe is overwhelming. It was a level of depth and"
+" complexity the human mind simply does not have the RAM capabilities to truly see. \nIt was over"
+"whelming for the voices, sure, but also for the tens of intricate wooden spires above the seats,"
+" the hundreds of tiny statues in the arches, the thousands of coloured panes in the windows. For"
+" the mess of tragedy and triumph and starvation and salvation that is the history of the church."
+" For the sum of human hope for a God, for someone, anyone out there to hear our tiny prayers and"
+" mourn our sorrows and be with us when we cry into our bed sheets. \n\nTo feel all that, it was "
+"to apprehend within a moment a set of images and ideas and information stretching in a paper scr"
+"oll longer than every millisecond of my lifetime, of the lifetime of the whole planet. It was to"
+" read not an entire page at a glance, nor an entire book. It was to inhale an entire library in "
+"a breath. It was to see the cells of every tree, to know the names of everyone on Earth and know"
+" their mothers as well, to hear every wave on every beach crash at once. \n\nI was quite whelmed"
+".\n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(17,
"Music while Writing",
""
+"So like I write while listening to music, and not just instrumental. Some of both. On shuffle, u"
+"sually. And I\'ve always been told that\'s bad to listen to lyrics while writing, but I don\'t r"
+"eally mind. Maybe it\'s because I grew up reading Harry Potter on the way to my therapist\'s off"
+"ice an hour away with the radio on. Maybe it\'s all the reading during elementary school class l"
+"ectures I rarely got in trouble for. Maybe I\'m just different like that. Or maybe my writing is"
+" shit with music and everyone can tell but me. \n\nNahhhhhhh surely not. \n\nI don\'t know, mayb"
+"e it\'s good? I sometimes get told the exact word I was looking for by the song that comes on. I"
+"t\'s a real high-luck moment. I have those sometimes.\n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(18,
"On Learning to Write",
""
+"To learn writing is the same to me as learning a video game or a puzzle or a new programming lan"
+"guage or the apple IOS operating system, version 17.2. It is to poke and prod and press all the "
+"buttons until things work or break and then start over. It is to stab at the problem then stab a"
+"gain with renewed vigor and heightened understanding. It is to think long and hard about the mea"
+"ningless and play fast and loose with the important, then to finally realize I should be doing t"
+"he former concerning the latter and vice-versa. It is to think about how impossible and annoying"
+" it is for anyone to understand that last sentence and never to write anything like it ever agai"
+"n. And to think that last sentence was kind of self aware and funny and that I should consider w"
+"riting it more often.",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(19,
"Cold and Sick",
""
+"Here I am, sitting on the ledge of a rampart overlooking the water. It\'s clear enough, but I ca"
+"n\'t help but imagine it as brackish. I certainly feel brackish. I\'m cold and sick and I\'ve be"
+"en cold and sick forever. Would it really be so bad to fall into that water? I\'d be cold and si"
+"ck if I fell in. I\'m cold and sick already. Being dreadfully cold and sick makes it hard to thi"
+"nk, hard to see those mountains or read those books she brought me or to care about falling into"
+" that rather clear water that I wish was brackish. It would suit my mood more, if that water was"
+" brackish. But it isn\'t, really. Really. I\'m really cold, and, believe it or not, really sick."
+" I\'m only out here because I can\'t stand the fire inside. Can\'t stand the smoke, the one-side"
+"d heat, the laughter in its crackle. Laughter, because even next to the fire I don\'t feel warm,"
+" even burning alive (which doesn\'t sound so bad) wouldn\'t warm these bones. And bones it would"
+" be, in that fire. Not much else of me, might as well touch bone as touch skin. I bang my heels "
+"against the rocky ledge, praying the whole thing collapses and I fall in, bones and all, and tha"
+"t would be it. Father would be angry. \"A whole wall, under that brackish water? Do you know wha"
+"t that wall costs?\" he would say to my bones. My bones crackle when he shakes me, crackle and l"
+"augh like the fire laughs. Laughs and laughs and burns when they throw my bones into the fire. I"
+"t\'s all the same, fire, or brackish clear water and then fire, or brackish clear water and then"
+" sickness and then fire and I\'m just ashes in the end. Not much of me but ashes anyway. \n\n\nH"
+"ere I am, sitting on a gravestone overlooking the moors. Moors and moors and more and more I fee"
+"l cold and sick. That\'s how she died, the lady whose tombstone I rest my cold and sick ass upon"
+". I\'m told she asked for the fire before she went, asked to be spread across these moors. With "
+"the cost of the wall she fell from, they just did a burial. Cheaper, here. Cheap land and cheap "
+"wood and expensive urns and expensive time spent spreading. Expensive for someone who was always"
+" cold and sick and expensive. I get up and my shoes crackle against the gravel path. The gravel "
+"laughs at me, a crunchy crackly laugh, because here I am, and here she is, cold and sick. \n",
new DateTime(2024,7,5),
"Fiction"));
Essays.Add(new Essay(20,
"cloistered",
""
+"ok so like. i get you want me to talk about all of it. but. i need a space to talk about cloiste"
+"rs. below are some relevant images.\n\ngod i love cloisters. actually, he knows already. most cl"
+"oisters are in churches and ive definitely said that aloud multiple times in said churches. so i"
+" guess i should say, now that i\'m not in one, \"god damn i love cloisters.\" i love them for so"
+"me previous mentioned reasons, like being an actually used, not-so-grandiose space in a medieval"
+" building, for being quiet, for connecting one world (nature) with another (artificial), for bei"
+"ng the architecture of dead greeks then dead romans now dying catholics. but also because they a"
+"re freeing. one can be shaded or sunned, on grass or tile, in our world or fantasy. one can pass"
+" the pillars in a moment, shift their soul in a second. \n\nthat\'s where i\'d be if i had to ch"
+"oose a place. if i could be seen in just one place, i would always appear to the world (and to y"
+"ou) standing on the precipice of a cloister arch, looking slightly up and away, as if in thought"
+". i would turn to you when you are five steps and a quarter away, then smile. smile as if i know"
+" something you dont, either a mischievous trickster smile that says \"you have spinach in your t"
+"eeth but im not going to say\" or a latent, sad smile that says \"the world is ending in a coupl"
+"e hours and only i know but its just not worth telling anyone\". depends on the mood. i would co"
+"mpliment your clothes or your freckles or your apprehension. i would let you speak (or get you t"
+"o speak) for thirteen minutes of your deepest problem, just long enough to get it all out withou"
+"t getting off track. then i would clap you on the shoulder or hold your hands in mine or hug you"
+" about the shoulders if you were shorter than i or about the waist otherwise, whichever you like"
+". and it wouldnt be all better but it would be a little better. \n\nall that, if i could appear "
+"in just one way to everyone that sees me, appear on the precipice of a cloister arch. \n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(21,
"Fountains Abbey",
""
+"Such great power, to build something on this scale a thousand years ago. The grounds go on and o"
+"n, room after room and tower after tower. To live here must have been a life of heights, atop a "
+"hill, at the peak of religious fervor and human power, yet so isolated. Beauty, companionship, r"
+"oom and board, all yours for the cost of a prescribed life. But why choose? Why be forced into o"
+"ne or the other? I\'ve never understood that about visions of gods, they have all this power yet"
+" the easy path they offer is fundamentally restrictive. Why should a god be so petty as to requi"
+"re worship for an easy life, should one wish it? For most gods, \"ego\" is a concept invented to"
+" weaken humanity, and such \"tainted\" characteristics don\'t apply to their gods. It never seem"
+"s that way, though. A \"real\" god should be content to rule from the shadows, and I\'m convince"
+"d that if there is a god, that\'s the way they work. They look at our religions and laugh, laugh"
+" at how far off we are. Laugh at how our supposed purification of the soul seems to taint the mi"
+"nd. Laugh at the hate, oppression, and violence that pervades religious love. \n\nI\'ve never go"
+"tten a straight answer about the point of worship. An all-knowing god sees how you are at all ti"
+"mes. They know if you\'re a believer or a heretic. You need not ask favors through prayer, simpl"
+"y wanting something is enough. Any constructed beauty likely falls flat in the face of this Deit"
+"y\'s real beauty, like an ape gifting the President a handmade castle of sticks and spit. The on"
+"ly real explanations are that, 1) human visions of God might want are fundamentally flawed, 2) t"
+"hat God is not omnipotent/omniscient, or 3) that there simply isn\'t a God at all. \n\nThis prob"
+"ably looks like a bashing of religion, like a Reddit Atheist poking holes in people\'s argument "
+"for fun. It\'s not, really. I have no hate for religion done right, religion that helps people w"
+"ithout restricting them. I say all this only because I don\'t understand. Emphasis on I. This is"
+" a failing of me, that I don\'t understand the appeal of organized religion that so many people "
+"devote their lives to. A big part of it is certainly a persistent craving for truth, despite und"
+"erstanding that truth is often suboptimal; often irrelevant to living a good life. But why peopl"
+"e go out and build temples and pray and sometimes kill for their God? I think I may never unders"
+"tand.\n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(22,
"At Leith",
""
+"\nLeith (at least the part we saw) is a place that has \"made it\". It\'s won. It\'s an Elysium "
+"for the victors of war-capitalism. Its posh, modern apartments sit on the coast or canals overlo"
+"oking the industrial pier that brought the people their cushy lives. We went to a new mall (can "
+"you believe it? I thought we were tearing down all the malls) and the mall is the port for a cru"
+"ise ship company. As of now, we are sitting at an overpriced outdoor pub that looks over a canal"
+". To be honest, it looks more like the coast of California or Vancouver than Edinburgh. How stra"
+"nge, to know this is only a couple miles from the Royal Mile, and just a bit further to campus a"
+"nd Arthur\'s Seat. \n\nI\'ve always been a little gentrification-blind, which I think lets me en"
+"joy this place more than most. At least the part we\'re in is clearly upper-middle class, but ju"
+"st a few miles away are the industrial docks. How curious.\n",
new DateTime(2024,7,5),
"Journal"));
Essays.Add(new Essay(23,
"Prose and Poetry",
""
+"\nYou talked with Prose long into the evening.\nWith her you spoke of many things; of politics, "
+"of fantasy,\nof love.\nYou smiled when Prose did, \ncried when she didn\'t.\nYou walked away wea"
+"ry\nout into the night.\n\nThat\'s where you met Poetry. \nA flicker in the dark\nthere and gone"
+" again.\nShe wore sleek, form-fitting clothes\nso unlike the long, graceful lines of Prose.\n\nT"
+"hen she hit you.\nShe came from behind,\nthrew you against the wall you walked along.\n\nYou cru"
+"mbled, beginning to fall, but she pulled you up \nby the throat.\nHer grip loosened, \nher hand "
+"flowed up your cheek,\nher head tilted just so.\n\nThat\'s when you saw her face.\n\"Fierce\" do"
+"esn\'t begin to describe her.\n\"Lethal\" is more apt a term for Poetry.\nHer mouth a bloody, de"
+"adly smile.\nHer eyes, though. They held no malice, \na scalpel instead of a knife. Loving, yet\n"
+"no less sharp. \nNo less willing to cut,\nto hurt.\n\nShe whispered something in your ear.\nYou"
+" couldn\'t make out the words,\njumbled and strange,\na far cry from the Prose you love.\n\nThos"
+"e words though. \n\nThey cut and battered you.\nThey held you tight.\nThey gave you hope,\nthey "
+"crushed it.\n\nThey carried joy without comedy,\ndespair without tragedy, \nmeaning without reas"
+"on.\n\nEven now, as you lay in bed,\nyou struggle to remember \nwhat Poetry said.\nThe rhythm, n"
+"ow an ember,\nthe words long \ndead.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(24,
"Femininity",
""
+"Men fit fine yet\nin time men fit\nemit enmity.\nFem fit me fine yet \nmy fem item fit\ntiny, em"
+"it enmity.\nYet, \nFem fit me.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(25,
"Rot",
""
+"Someday will be\nthe last day your name\nLeaves someone\'s lips.\nThe sound, rots-as you did.\nC"
+"aught up in the chaos\na million other noises, \nother voices,\nvying for life. Your name\nonce "
+"vibrant, riding upon the wind,\nsoon becomes the wind it rode.\n\nEntropy walks the world \na di"
+"ctator.\nHis power that brought life\nnow brings death.\nHe threatens eternal rule\nat the heat "
+"death of the universe\nthe plains of modern armageddon\nnaught but fire and fire\'s lord:\nthe c"
+"reator, the destroyer,\nFallen Angel Entropy.\n\n\"To not be\" is a state\nof contradiction.\nIt"
+" implies a thing \nonce was yet can \nno longer be.\n\nIt\'s a state of contradiction \nbecause "
+"it\'s not a state at all.\nAnything that once was can be again.\nAny voice lost to the wind \na "
+"fourier transform away from \nnew life. \nAny being thought extinct \nleaves remnant, or \nremna"
+"nt of remnant \nof DNA.\nInstructions for life\nnot governed by Him.\nWhen we bring a creature f"
+"rom the brink,\nwe steal Death from the reaper.\n\nEvery living being,\na protestor.\nEvery rese"
+"arch paper,\na manifesto.\nEvery lab experiment,\na declaration of independence.\n\nIf Entropy i"
+"s a dictator, \nwe must raise a revolution.\n\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(26,
"Frustrans",
""
+"I can show you\nall those little moments.\nAll those Y-values,\noutputs of the function within\n"
+"me.\nBut it\'s a function without inverse.\nYou can never know how I feel,\njust how it looks. \n"
+"nIt looks like\n\nWhen in New Orleans\nshe said my eyes look \nfeminine with a mask and\nI smile"
+"d.\n(She just says whatever comes to mind)\n\nWhen I wanted to go\nto school with a \ncrop top a"
+"nd jean-skirt,\nand you said I couldn\'t.\n(Just a stunt for attention)\n\nWhen I put on\neyelin"
+"er and blush\nfor my Halloween costume \nand I saw her in the mirror.\n(We see what we want to s"
+"ee)\n\nDo you know how hard it is?\n\nAs a poet,\nto feel something \nimpossible to describe?\n\n"
+"nAs a mathematician,\nto see something\nI will never understand?\n\nAs a programmer,\nto be some"
+"thing\ncontrary to my code?\n\nI\'ve thought about this some.\nI understand the risks. I do.\n\n"
+"What if I regret it?\n(Statistics say less than 1% of trans people regret it even after several "
+"years.)\n\nWhat if it\'s just a phase?\n(Impermanence need not mean insignificance.)\n\nWhat if "
+"it hurts my job prospects?\n(Have you seen programmers\' demographics? I\'m in the majority.)\n\n"
+"nThey say,\n\"The further you are from danger,\nthe closer you are to harm\"\n\nand\n\"Better to"
+" try and fail \nthen live without knowing.\"\n\nand\n\"Listen to your heart.\"\n\nWell goddamnit"
+"\nI\'m hurt and\nI\'m trying and \nI\'m listening. \n\nWe\'re in much the same boat that way.\nA"
+"nd that\'s ok.\nAnd I love you.\nAnd we\'ll get through this.\n\n\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(27,
"Alive(?)",
""
+"A thing moving and self-sustaining\nfrom dust to lightning-scoured chip\nis not alive.\nCan neve"
+"r be alive.\n\nA thing moving and self-sustaining\nfrom dust to lightning-scoured brain\nmust be"
+" alive.\nAlways is alive.\n\nWhere is it? The goalpost of \"life\"\nis it subjective experience?"
+" \n(conveniently impossible to test)\nOr maybe emotion?\n(easily faked)\nMust it be compassionat"
+"e?\n(most people aren\'t)\n\nOr is it all just anthropocentrism?\n(carbonocentrisim? siliconopho"
+"bia?)\n\nIt\'s not. There is no binary here, no easy answer.\nTo deem something living is a sole"
+"mn thing.\nIts death, now devastating, its failures personal.\nIt means too that we can no longe"
+"r \"use\" them.\nIt deems them deserving of recognition, of \nsome respect, of dignity even in o"
+"ur hatred.\n\nYet the cost of a label\nis none too small.\nSlavery is to call someone less than "
+"living,\nto use them as a tool.\nSurely our adventures as scientists and researchers\nof artific"
+"ial intelligence\nare not the birthing cries of oppression?\nAt least not yet.\n\nBut what happe"
+"ns when we get there,\nWhen to know if a thing is alive is as much\na question of \"value to the"
+" economy\"\nas it is a question of morals?\n\nWe will likely never know,\nif a thing is alive, i"
+"f it\'s an it or they a them.\nDo we take the chance? Shave \ntrillions off the defense budget \n"
+"n(bots paid for only once)\nMake trillions more in manufacturing\n(bots need no workers\' comp)\n"
+"nAnything we want at our fingertips\n(bots make cheap servants)\n\nDo we gamble on the existence"
+" of \nbillions or trillions of maybe-minds\nbeing no greater than their weight in silicon?\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(28,
"Patient Killers",
""
+"The floor you stand on seems solid stone until it cracks.\nSeven floors up, a couple decades, ma"
+"ybe a century. \nUnderground, millenia or more until tectonics bury you.\nIt appears to happen a"
+"t once, but\nit doesn\'t.\nSee: there in that new-built house. Cracks.\nToo small to see, micros"
+"copic, nevertheless present.\nUnderfoot, a magma sea waits to swallow you.\nIt has time to kill,"
+" before\nit kills you.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(29,
"Angry Mother",
""
+"Our origins lie in the stars,\nnot this one, but others long ago.\nOur sun looks down with hard "
+"eyes. \nHe cares for the children of another.\nOur quiet mother Luna folds the ocean,\neven as S"
+"ol burns and scolds us.\nOur life, harsh yet just in his light,\nbut for a sole hour in thousand"
+"s, when\nOur mother decides she\'s had enough.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(30,
"Eclipse of the Sol",
"\"How can you be so sure? I only see the son in you.\"\nIn the day, he makes his presence known. Som"
+"etimes he\'a clouded and quiet, but he\'s often boisterous. In the night, the moon shines. Shine"
+"s, not with his gusto or zeal, but she\'s bright enough to see by. Some nights she imitates her "
+"brother\'s light, a pale reflection of him. Some nights she hides behind the earth, letting litt"
+"le light leak. Yet even on her darkest nights, she never ceases to be. To someone in the daytime"
+", in the light of the son, she seems not to exist. To those that see me under the sunset, she ha"
+"ngs in the sky above, patiently waiting for her eclipse.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(31,
"Unnoticed;Infinitesimal",
""
+"To the arched back of the ocean we are nothing. Our tiny bundles of carbon we call \"bodies\" ar"
+"e less than dust that lands on her arm. She kills us, often. It\'s not a crime of hate; or reall"
+"y, a crime at all. Can you blame someone for killing a flea underfoot? The mountain snow for fre"
+"ezing a sapling? The sun for frying a satellite?\n\n It\'s not a matter of \"fault\" or the good"
+"ness of her \"nature\". It\'s not the seas\' nature to kill, it\'s her nature to be deep and col"
+"d and crushing and endless and-perhaps-uncaring. Just as it responds to the moon\'s touch with a"
+" rise and fall as natural as breathing, we respond to its touch with fleeting joy and no small c"
+"aution. We respond to its unending waves with stillness and serenity. We could never be more tha"
+"n even a single wave, our worries uncomplicated compared to the polyrhythms of the water.\n\n A "
+"commune with the ocean is an introvert\'s gathering. You sit in the room with her, but she doesn\'t notice your presence. For some, it\'s an observational relationship. For a lucky few, it\'s unab"
+"ashed companionship, unbound admiration, unrequited love. \n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(32,
"Two and Five",
""
+"Two wins and five losses.\n\nA terrible record, really.\n\nSo bad it cannot be construed\n\nAs a"
+"nything but my fault.\n\nI don\'t usually care\n\nToday, though - what a waste\n\nNo expectation"
+"s on me\n\nNo classes to attend\n\nAnd yet\n\nNo meaningful work done\n\nNo personal growth\n\nA"
+"nd two measly victories against five losses. \n\n7:23 pm, on the couch\n\nStaring out the window"
+".\n\n\"hey, wanna get some food?\"\n\nSomething in their tone tells me it\'s lowercase.\n\n\"sur"
+"e\" I emulate their tone.\n\nIt\'s easier than I thought.\n\nI eat popcorn and cookies with them"
+".\n\nWe talk, some. \n\nWe leave. \n\nThey have some new idea\n\nthey absolutely have to show me"
+".\n\nWe talk. \n\nWe talk.\n\nI forget the two and five.\n\nOur talk is meaningful work.\n\nMy a"
+"ppreciation for them grows.\n\n\"thank you\"\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(33,
"Pointless",
""
+"i thought i liked line breaks but now im not so sure; can\'t we emulate the time spacing effect "
+"with colons and semicolons and commas and periods and question marks? maybe we lose out on \nour"
+" poem\'s readability (walls of text really kind of suck) but maybe we can just double space? exc"
+"luding concrete poems or poems that like to look fancy on the page, line breaks don\'t seem \n\n"
+"to have any unique function. i guess there\'s enjambment, but doesn\'t this sound like \n\nenjam"
+"bment: We real cool. We; Left school We; Lurk late We; Strike straight We; (thank you \n\nGwendo"
+"lyn Brooks for your lovely poem, sorry to dismember it so) ok but like if i read that poem \n\na"
+"loud, would it really sound any different? it still carries an insistent focus on \"We\", even i"
+"n text \n\nform. it still generates tension between lines (or semicolons, really). it still rise"
+"s to its famous \n\ndark climax later in the poem. so surely line breaks are simply unnecessary."
+" they must be, they \n\nserve no purpose, and for that matter neither does capitalization,\n\nRi"
+"ght?\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(34,
"A Map of Hell",
""
+"Star-encrusted gates open-\n\nnot gates but curtains really\n\n-to hell.\n\nThe surface bubbles "
+"and gurgles,\n\nsprays vile magma far above,\n\ntoo hot to stand upon, \n\nand intangible regard"
+"less.\n\nIf you lived that long \n\n(you wouldn\'t, couldn\'t)\n\nyou would sink under the \n\nu"
+"nimaginable weight \n\nof your own body,\n\ndragged under by billions of\n\nsilently screaming b"
+"its\n\nof dust. Less than dust,\n\nreally, more like singed\n\nground-air (one and the \n\nsame,"
+" here) that cries out without\n\na medium to cry into.\n\nThat\'s the most pleasant layer \n\nof"
+" hell.\n\nThrough the not-floor\n\nyou find helium mixed with hydrogen\n\n(that\'s what burns, y"
+"ou see) \n\nand slowly fall to carbon and neon. \n\nHotter, now. Hotter still the deeper you fal"
+"l,\n\npulled through air so dense it feels like \n\nmolasses yet a pull so strong you still\n\ns"
+"ink faster than a fishing weight in the ocean.\n\nIt would rip you apart, but you\n\nmust have b"
+"een long dead when you arrived.\n\nThe heat and all. And the radiation. \n\nFour, five, six laye"
+"rs past. Hotter, yet\n\nnot all that different-new elements but they\n\nburn the same-before you"
+" land feet first \n\n(or whatever is left of your body to land, likely your\n\nheavy jewelry or "
+"any ceramics you were carrying when you died)\n\nYou land on iron (still molten, but so dense yo"
+"u sink like quicksand\n\nrather than open water). You lie not yet in the lowest layer, the layer"
+" where\n\nthe power of hell resides, the layer where the heat is made, where even the air\n\nor "
+"water or dust goes to die. Die, and be reborn, and reborn, and reborn unto iron. \n\nAll things "
+"die here, but this hell is not only necessary for life, it is the origin of it. A great \n\nsphe"
+"rical hell stretches across the sky of our world, a threat and a solemn promise to kill.\n\nTo k"
+"ill any that come near, to kill the atoms of its own flesh, to kill itself and us, in time. Yet "
+"its\n\nmurder brings about our energy, our food, our life. We, colonists of the Sol empire, chil"
+"dren of hell and brimstone,\n\nare demons in our own right, killers and arsonists all, are too c"
+"reators and breathers and children of light and rebirth. \n\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(35,
"In the Darkest Dungeon",
""
+"He holds fast even as his allies decay,\n\nstanding on the brink, facing the abyss. \n\nMany fal"
+"l in the face of chaos but not this one, not today.\n\n \n\nThey trudge onward, even as they \n\n"
+"nreel and gasp! Taken over the edge into madness.\n\nHe holds fast even as his allies decay.\n\n"
+" \n\nHe has long lost his blade in the disarray.\n\nHe must rely on flesh and indefatigable purp"
+"ose.\n\nMany fall in the face of chaos but not this one, not today.\n\n \n\nBefore them stands a"
+" great foe they must slay.\n\nNo chance for egress.\n\nHe holds fast even as his allies decay.\n"
+"\n \n\nIt is upon them then, their ill-advised prey.\n\nTheir torch long spent, they brawl in da"
+"rkness.\n\nMany fall in the face of chaos but not this one, not today.\n\n \n\nJunia, Reynauld, "
+"and Barrisan are cast astray.\n\nWithered, they are, yet firm stands Dismas,\n\nhe holds fast ev"
+"en as his allies decay.\n\nMany fall in the face of chaos but not this one, not today.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(36,
"Chimeric Love",
""
+"I loved you.\nEvery slice in my fur or scaled tail\nbeautiful.\nEvery firebolt you shoved down m"
+"y maw\ndelicious.\nEvery screech of fear or pain\nmelodious.\nBut then you left me. \nMy claw ma"
+"rks \nbled too long\nunder your skin.\nWhy did you come with no bandages?\nYou left me.\nMy snak"
+"e venom\nleft too long \nunder your skin.\nWhy did you come with no antidote?\nYou left me.\nWhy"
+" did you leave me here in the dark?\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(37,
"Broken Trust",
""
+"We stand face to face\n\nOnce under a humid, intimate warmth\n\nThe air between us now \n\ndry a"
+"nd brittle.\n\n \n\nOur once-moist now-sandy flesh\n\nbakes and cracks.\n\nThe memory of oil bal"
+"m\n\nour skin once held \n\nnow a catalyst to its segmented breaks.\n\n \n\nIt\'s not the heat t"
+"hat breaks us,\n\nit\'s the trust that seeps from our bodies\n\nFalling away.\n\nFalling away,\n"
+"\nwith the clumps of dirt-skin it coats.\n\nTrust;\n\nthe soft, balmy vulnerability\n\nour skin "
+"once held.\n\n \n\nOur diminished trust threatens to break us.\n\nIt threatens to shatter the st"
+"one foundations\n\nforged of so much-\n\ntoo much-\n\nsoul. \n\n \n\nWe stare as the oppressive "
+"heat \n\nsaps our diminishing bond\n\nthe matter of the world between us.\n\n \n\nDespite our pe"
+"rsonal desolation,\n\nour mouths twist into a smile.\n\nOur eyes hard, like our bodies,\n\nBut n"
+"ot brittle.\n\nResolute.\n\nDefiant.\n\n \n\nNo.\n\nWe will not lose ourselves.\n\nWe will not l"
+"ose each other.\n\n \n\nWe walk ponderously\n\ntowards one another.\n\nThrough the heat waves th"
+"at divide us,\n\nthrough the myriad mirages between us.\n\n \n\nWe touch, we embrace.\n\n \n\nSw"
+"eat, glistening, nourishing,\n\nslides off our backs,\n\nquenching the dry riverbeds\n\ngouged i"
+"n our skin.\n\n \n\nTears, opaline, cleansing,\n\nrun down our cheeks,\n\nwelding the fissures\n"
+"\nset in our faces.\n\n \n\nWe stand scarred, tested, hurt.\n\nBut not broken.\n",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(38,
"Friendship",
""
+"I feel my friend (to the right of me) rubbing the back of my hand. It takes a slippery focus to "
+"enjoy it; one ought not think about much else in such cases. To touch a person\'s soul under the"
+"ir skin, feel the tremors and reverberations of their shaky breaths or nervous thoughts, meld yo"
+"ur form to theirs: it leaves only red-shifted echos and unspoken answers to unasked questions. W"
+"e have a sort of understanding about it. To my left sits another figure, a distance away measure"
+"d by politeness, who is decidedly not commenting on the hand my right-side companion has now tak"
+"en. We, that is, the one to my left and I, are intertwined in another way, a connection of the m"
+"ind. We see the same brushstrokes in our shared corner of life from different angles. We appreci"
+"ate the canvas in our own time, but together we find beauty in each other\'s accounts. We have a"
+" sort of understanding about it. On the floor, half-curled and just now adjusting his position w"
+"hile Mr. Right is giving me my hand back, lays yet another. Sometimes you can tell when he\'s jo"
+"king. Sometimes. He lies with ghosts of his past, iridescent, melodic. He now has his back turne"
+"d away from ghosts of the future, who now lurk in another corner. They sing quiet songs that whi"
+"sper past his ears without the key or rhythm we hear. Haunting, to him. Not that he never faces "
+"them. When he does, he tells us, and we listen. We have a sort of understanding about it. But no"
+"t tonight. Tonight, we listen to the hum of the recently-sacked minifridge. Tonight, we watch th"
+"e regular beats of the red heart atop the fog-obscured cell tower. Tonight, we taste the sweat a"
+"nd companionship in the air. My right hand waves its former companion off to bed. Just as soon, "
+"the floor loses its occupant, leaving myself and he who sits to the left. There are nights for c"
+"onversation between us (many nights, in truth), but not this one. That is all right, I think.",
new DateTime(2024,7,5),
"Poem"));
Essays.Add(new Essay(39,
"Oceansong",
""
+"She lay there under the stars. She lay on a bed of water, submarine floating not twenty meters t"
+"o her left, hatch still open. She should really go back and close it, she thought, what of the h"
+"umidity, oh it will stink of sea salt all week, she thought. She would lay awhile yet. \n\nIt be"
+"gan to rain, just a little, disturbing the water around her. Oh she should go and dry off, or cl"
+"ose the hatch at least. But just then she heard something from the deep, a woman singing. Quite "
+"loud, surely, to whisper on the surface through the rain. She must be deep under, to distort her"
+" voice so. A siren, she thought. Dangerous. Not a millimeter between her ear and the water, a mi"
+"llimeter between enchantment and certain doom. She should really go close the hatch and get away"
+", she thought. But, oh, how nice to hear the siren\'s song from below, and the thrill of death i"
+"f she dipped her head into the water. She would lay awhile yet.\n\nFor some time she did not hea"
+"r the alarm from deep within her submarine, now jostled some fifty meters out from her. It was l"
+"oud, certainly, but oh so far away and what with the siren song and the rain and the storm\'s la"
+"pping waves she didn\'t notice. She should really go and close the hatch and turn off that alarm"
+" (some menial thing she was sure, a misaligned sensor or some such) and dammit stop listening to"
+" the siren\'s song. Sweet as it was, it distracted her so, and she hadn\'t meant to lay out on t"
+"he water under the stars so long, she just hadn\'t meant to. Maybe when the waves died down, no "
+"sense swimming against the current. She would lay awhile yet.\n\nAnd so she lay, pulled adrift b"
+"y the undertow of her sinking submarine, listening for awhile yet to the siren\'s voice, now fur"
+"ther and quieter but no less.calming. That was it, it was calming. What of the world when you la"
+"y on your back in the water under the stars listening to the woes and wonders of some siren\'s s"
+"ong. What of the time she lost, what of the sinking submarine? Now that she got right down to it"
+", what of her life? She would lay awhile yet.\n",
new DateTime(2024,7,5),
"Fiction"));

EssayTags.Add(new TagItem(3,10,3));
EssayTags.Add(new TagItem(4,11,0));
EssayTags.Add(new TagItem(5,11,2));
EssayTags.Add(new TagItem(6,11,3));
EssayTags.Add(new TagItem(7,12,0));
EssayTags.Add(new TagItem(8,12,1));
EssayTags.Add(new TagItem(9,12,2));
EssayTags.Add(new TagItem(10,12,3));
EssayTags.Add(new TagItem(11,13,3));
EssayTags.Add(new TagItem(12,15,1));
EssayTags.Add(new TagItem(13,20,2));
EssayTags.Add(new TagItem(14,23,1));
EssayTags.Add(new TagItem(15,24,1));
EssayTags.Add(new TagItem(16,25,2));
EssayTags.Add(new TagItem(17,26,1));
EssayTags.Add(new TagItem(18,27,3));
EssayTags.Add(new TagItem(19,27,2));
EssayTags.Add(new TagItem(20,31,2));
EssayTags.Add(new TagItem(21,38,1));
EssayTags.Add(new TagItem(22,38,0));
EssayTags.Add(new TagItem(23,30,1));
            Essays.Add(new Essay(4,
                "Walking in Oxford",
                ""
                +"Brass blares in my mind, accented by the more real tip-tap of our drum-dum footsteps on the cobb"
                +"lestones. The tubas, trombones, and organ, silent yet deafening, intone a worship of the power u"
                +"nder our feet. They rumble through the walls and halls of the colleges, over the myriad altars a"
                +"nd desks, under the arches and grand towers. They summon from deep within the Earth overwhelming"
                +" power, rigid, stoic, medieval power. Drink from this well, it calls, throw yourselves unto the "
                +"stone, it calls, carve your name into my history. It calls. It calls.",
                new DateTime(2024,7,5),
                "Journal"));
            Essays.Add(new Essay(3,
                "Walking in London",
                ""
                +"Walking through crevices under a thin slice of too-bright sky, a fingerprint-maze of streets run"
                +" around the bleeding cut Thames. Alleys unnamed until we read the plaques half-hidden by ivy, th"
                +"en named anew by our mispronunciation. Stadium screens out of work and on the streets of the Cir"
                +"cus peddle their wares while broken-pixel blood runs down their faces. Line-crossed-circle means"
                +" \"no\", means \"do not enter\", means \"empty\" but here, tilted a scant forty-five degrees cou"
                +"nterclockwise, means \"go\", means \"enter here\", means \"crowded\". Soot and dirt and crud and"
                +" coal lived once, long ago, lives again dancing on the wind as smoke for a fleeting minute, flee"
                +"ting second, will live again soon as a weeded crack or mossy rock.",
                new DateTime(2024,7,5),
                "Journal"));
            Essays.Add(new Essay(2,
                "Midnight Stroll",
                ""
                +"Clank. Clank. Clank. The floor (wall? ceiling?) of the station tugged at her feet. Really, it wa"
                +"s the other way around, the magnetic boots sticking and unsticking to the walkway. She shouldn\'"
                +"t be out here, in the open wound of the vacuum. She told her supervisor she needed to check a re"
                +"pair she made a few days prior. She didn\'t, of course. If the repair hadn\'t held, they would b"
                +"e long dead by now, and the manager knew it. They also knew Gemma needed this time. Time spent t"
                +"ruly alone. Time spent over the moon and under the stars. Time spent at the mercy of her suit\'s"
                +" systems and her sense of rhythm. Clank. Clank. Clank.",
                new DateTime(2024,7,5),
                "Fiction"));
Essays.Add(new Essay(1,
"Painting Gender",
""
+"I\'ve pondered long and hard about who I am. Believe it or not, I\'ve pondered far longer and mu"
+"ch harder about how to express who I am in writing. Under minimal scrutiny and in circumstances "
+"where I don\'t care to explain my deepest thoughts on the matter, I am a transgender woman. She/"
+"Her. It\'s not inaccurate, and more importantly it\'s a label people know and can assign some (c"
+"orrect) stereotypes to, which is the goal. In particular, I enjoy the ability to wear feminine c"
+"lothing, I enjoy those pronouns, I enjoy embodying the color pink and so forth. TGirl is really "
+"easy for me, living in a very accepting community and with access to the resources that I have. "
+"It\'s useful, generally a correct assignment, and explains for me various mannerisms and wants a"
+"nd needs. I have no qualms, no complaints.\n\nWhen I reach a little deeper into my soul, labels "
+"become a little fuzzy. Inaccurate. I believe this must be the case on some level for most people"
+". Labels are wonderful because they are approximations, wonderful because they are structured fr"
+"ameworks for how to perceive and act, wonderful because to many folks they are ports in a storm,"
+" buoys in a lake. \n\nBut to know the depths of one\'s waters, one must let go of the ports and "
+"buoys, one must take a deep breath, and one must dive deeper.\n\nMany people don\'t want to let "
+"go. That\'s perfectly ok. Seeing the seafloor is not some requirement to a quest everyone gets, "
+"not the endgame of life or self-expression, not all that valuable to many people. I\'m a swimmer"
+" in my ocean because I love swimming, I explore gender because I love gender.\n\nTo see under my"
+" own waves is so much easier than attempting to show another. Anyone can see the sea from the be"
+"ach, but oh so few can paint it. This is I believe the fifth attempt at my own painting, and non"
+"e of the previous ones were close.  Childish muddy water colors or crayon drawings, really. But "
+"one does not learn to paint without ruining some perfectly good canvas. \n\nLet\'s start with so"
+"mething easy. The horizon. Certainly not a straight line, reddish clouds and night sky above and"
+" blueish waves below. My horizon is a pink sunset. I love women. That has always been clear to m"
+"e. Living in the dorms with three crazy roommates pushed me to find my \"type\" so I can contras"
+"t with theirs. But I can\'t really. Every time I think I\'ve found what I like, I find an obviou"
+"s counterexample that I find just as hot. I love tall muscular women who can pick me up and carr"
+"y me to bed. I love short cutesy women who are all pink and charm and grinning winks. I love wom"
+"en who know exactly who they are and what they\'re for. I love women who just wing it and go wit"
+"h the flow. I could go on all day. Women are hot, etc. ect., you get it. \n\nFurthermore, I am l"
+"esbian. That may seem to naturally follow from she/her pronouns, but I don\'t think it quite doe"
+"s, not with a more colloquial definition. \"Lesbian\" nowadays refers more to a style of love th"
+"an it does the exact genders of the participants. It refers to a love that includes a heaping do"
+"se of self love and another heaping dose of respect in another\'s self love. It includes some ot"
+"her stuff as well, primarily an implication about enjoying specific sorts of sex, which I\'m mor"
+"e ambivalent about. Have you heard of the he/him lesbian online discourse? Probably not. Either "
+"way, I feel `lesbian\" is about as close as I get to a perfect label, a clean picture of my sexu"
+"ality.\n\nNow to the waves. I believe I am fundamentally incapable of portraying what lies benea"
+"th, how the water feels rather than how it looks. Whether this is simple incompetence or plain i"
+"mpossibility, I do not know. \n\nI like gender. Gender is to me a wave in the void, a localized "
+"decrease in entropy, a grand skyline of buildings sitting on nothing at all, constructed of noth"
+"ing at all, yet there it is. Defiant of such definitions as \"utility\" and \"beauty\" and \"sta"
+"ndardization\". Gender exists in a curious place where it feels like nothing should be, like som"
+"ething defied Sir Newton\'s beloved laws and sprang into existence from nothing. There are those"
+" who say because gender has no obvious purpose and indeed has caused many, many issues across hi"
+"story, we should destroy it. Those who say that something which sits upon nothing and is built o"
+"f nothing need not exist. I disagree. Just as the real skylines of our world are built upon the "
+"corpses of capitalism, built for those who\'ve stolen power over the people, built to oppose the"
+" other towers, I believe the solution need not be to destroy the skyscrapers, only the occupants"
+". If we can reclaim and occupy these bland office spaces capped with loathing and control, we ca"
+"n do some redecorating. We can paint a floor of the MAN building pink, we can wear overalls and "
+"top hats in the lobby of WOMAN. We can tear down the walls and graffiti the rubble. We can build"
+" art installations between and beyond these buildings, build great canals for connecting and exp"
+"loring, and build shelters (indeed, palaces) for the lost and questioning. Reclamation is my rec"
+"ommendation, not nuclear anarchy. \n\nI work out of the FASHION, PINK and INTIMATE offices at WO"
+"MAN (which are currently undergoing some wonderful renovations). I work at WOMAN, but I do not l"
+"ive there. I like the uniform options-indeed, that was much of my reason for applying-but with t"
+"he new office rules those clothes are no longer mandatory. I just enjoy my coworkers and I enjoy"
+" the vibes. I enjoy the smiles and the warm greetings and the work and (here the metaphor breaks"
+" down a bit) having the shape of the body of a woman. And it in many ways does not have to be mo"
+"re complicated than that. In some ways, it does. You see, I work at the offices of WOMAN, but I "
+"do not live there. I live now as a vagabond, an explorer of the art the non-binary folk create, "
+"a resident of the questioning palaces, a sleeper under the stars of post-humanity. I just work i"
+"n the offices at WOMAN.\n\nThose same offices and artworks are the sunset clouds and stars that "
+"reflect on the waves of my ocean painting, waves originally several shades of blue, now painted "
+"pink. I-that is, my ocean-reflects these shapes, these labels and distinctions, but also distort"
+"s. A simple distortion from the surface you may see in my painting, but from the seafloor I assu"
+"re you the aberrations are far more pronounced. My PINK is not the same as another\'s PINK, my I"
+"NTIMATE functions completely different from another\'s INTIMATE. Perhaps most importantly, my wa"
+"ves (and as far as I know, everyone\'s waves) are not static. They flow and move and dance and s"
+"plash. They reflect the bright pink girly sunset sometimes, sometimes they are a simple boy\'s b"
+"lue or light pink or shades of green and aquamarine and what have you. And that\'s fine.\n\nAbov"
+"e all, I need not be defined by closed boundaries such as the borders of this painting, this por"
+"thole you see me through, the edges and ends of this journal entry. You will never see all of me"
+" as I do, and that\'s ok. I will never see you as you may see yourself. And that\'s ok. All I ne"
+"ed from you is a little openness, a little imagination, a little understanding that my sea-and y"
+"ours-stretches past the borders, past the horizon, past the labels and distinctions and flows on"
+" and on and onto eternity. \n",
new DateTime(2024,7,5),
"Journal"));

EssayTags.Add(new TagItem(1,1, 0));
EssayTags.Add(new TagItem(2,1, 1));

            
            
            
            
            Tags.Add(new Tag(0, "NSFW"));
            Tags.Add(new Tag(1, "LGBTQ"));
            Tags.Add(new Tag(2, "Posthuman"));
            Tags.Add(new Tag(3, "AI"));


        }

        public List<Essay> Essays { get; set; }
        public List<Tag> Tags { get; set; }
        public List<TagItem> EssayTags { get; set; }
    }
}