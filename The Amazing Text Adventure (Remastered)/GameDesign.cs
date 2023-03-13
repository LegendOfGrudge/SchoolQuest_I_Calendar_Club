using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Amazing_Text_Adventure__Remastered_
{
    public partial class frmGameDesign : Form
    {
        string[] options;
        int[] positions;
        int position;

        bool isAlive = true;
        bool hasWon = false;

        bool hasBungee = false;
        bool hasCandlestick = false;
        bool hasChemicals = false;
        bool hasCoin = false;
        bool hasBrokenKey = false;
        bool hasKey = false;
        bool hasLooseleaf = false;
        bool hasSledgehammer = false;
        bool hasWeldingKey = false;
        bool hasWrench = false;

        string hairstyle = "HAS HAIR";
        int elevatorVisits = 1;

        string[] messages =
        {
            "Maybe learn how to spell",
            "I don't believe that's an item",
            "Pick a destination or item that's accessible from here",
            "I'm very disappointed in your spelling ability",
            "The words in UPPERCASE might be important here",
            "Have you tried putting in the message in ALL CAPS?",
            "Have you tried not sucking at this game?",
            "You'll never get to the office spelling like that",
            "You know for a teacher, you really suck at spelling",
            "Thank God you're not an English teacher...",
            "Are you trying to annoy me at this point?",
            "I listed places and items to access and you chose...none of them",
            "You chose...poorly",
            "OK and BACK are also acceptable choices sometimes",
            "LoOk I cAN SpeLL lIkE An iDiOT",
            "Choose an Item or Destination that exists. Thanks!",
            "If you're wondering why you can't get there from here, there might be other steps to take",
            "https://spellquiz.com/blog/spelling-training-spellquiz will help you. I'd suggest the Grade 1 quiz",
            "That cannot be done here",
            "Try something else",
            "GRANDDAD!!!",
            "You see a clue!",
            "I think we need to think of something! I think we need to think of something! GOOD THINKING!!!",
            "Try something else, this isn't working",
            "YOU'RE DEAD (But you should be spelling like that)",
            "STOP YELLING!!!",
            "Jesus Christ, look at it!",
            "A dictionary might help your spelling of some words",
            "Try Google, it might give you suggestions on how to spell",
            "I'll try spinning, that's a good trick!",
            "That option isn't available",
            "No, that's not possible!",
            "Words can be tricky",
            "Pick an option that makes sense in this context",
            "Think very clearly about what you're trying to do, then spell it correctly",
            "There's no prize for getting to the office fast, but you're not doing yourself any favours",
            "I wish you could go there, alas you cannot",
            "I wish you could use that, alas you cannot",
            "If only that was possible",
            "You can just say OK in some situations",
            "Typing BACK will take you to where you were previously",
            "Typing OK will acknowledge that dialog has happened and to move on",
            "You could always type OK and get on with your day",
            "You might have to type out the full item or destination",
            "That action cannot be performed here",
            "There is no destination to go to based on that action",
            "OK is an acceptable answer...sometimes",
            "You must unlearn what you have learned",
            "Nice! But that isn't an action here",
            "Choices, oh choices. You can pick a choice here",
            "So much to do, so little time for spelling mistakes",
            "What are you even talking about?",
            "That's crazy talk!",
            "No! Not like this!",
            "Forget all you know. Except spelling, you need to know how to spell for this",
            "Alright, alright, alright! is not an acceptable answer unfortunately",
            "Je ne parle pas français",
            "Type words before entering",
            "Where there's a textbox, there's usually code looking for correct spelling",
            "I want that as an item!",
            "Are you even trying?"
        };

        public frmGameDesign()
        {
            InitializeComponent();

            lblText.Text = "\nWelcome to the Amazing Text Adventure!\n\nStart?";
            options = new string[2] { "YES", "NO" };
            positions = new int[2] { 0, 0 };
        }

        private void txbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblText.Text += "\n";
                bool found = false;

                for (int i = 0; i < options.Length; i++)
                {
                    if (txbInput.Text.Contains(options[i]))
                    {
                        found = true;

                        if (position == 12)
                        {
                            hairstyle = options[i].ToString();
                        }

                        if (options[i] == "YES")
                        {
                            isAlive = true;
                            hasWon = false;

                            hasBungee = false;
                            pbxBungee.Visible = false;
                            hasCandlestick = false;
                            pbxCandlestick.Visible = false;
                            hasChemicals = false;
                            pbxChemicals.Visible = false;
                            hasCoin = false;
                            pbxCoin.Visible = false;
                            hasBrokenKey = false;
                            pbxBrokenKey.Visible = false;
                            hasKey = false;
                            pbxKey.Visible = false;
                            hasLooseleaf = false;
                            pbxLooseleaf.Visible = false;
                            hasSledgehammer = false;
                            pbxSledgehammer.Visible = false;
                            hasWeldingKey = false;
                            pbxWeldingKey.Visible = false;
                            hasWrench = false;
                            pbxWrench.Visible = false;

                            hairstyle = "HAS HAIR";
                            elevatorVisits = 1;
                        }
                        else if (options[i] == "NO")
                        {
                            this.Close();
                        }

                        position = positions[i];
                        storyChapter(position);
                        break;
                    }
                }

                if (!found)
                {
                    Random random = new Random();
                    int choice = random.Next(0, messages.Length);

                    lblText.Text += "\n" + messages[choice].ToString();
                }

                txbInput.Clear();
                txbInput.Focus();
            }
        }
        private void storyChapter(int position)
        {
            if (isAlive && !hasWon)
            {
                if (position == 0)
                {
                    // INTRO
                    lblText.Text = "\nYou enter the school for a typical day of work. Unlocking the door to room B4, you sit at your desk and start googling the\r\nbad joke of the week. Not that it'll really matter. All those crazy kids are too busy playing Space Monster Kitchen \r\nDesigner to care. Minutes turn into hours, and into centuries. You begin to notice the school seems a lot quieter than\r\nusual. You peek your head out the door and look both ways, but no one comes into view. You re-enter the room and think to\r\nyourself: \"Has the school been abandoned?\" If you want to explore and find a reason for this, you can EXIT the ROOM. You\r\nalso remember there was something to grab in the DESK DRAWER and the HAND-IN BASKET.";
                    options = new string[4] { "DRAWER", "HAND-IN",  "BASKET", "EXIT ROOM" };
                    positions = new int[4] { 1, 2, 2, 3 };
                }
                else if (position == 1)
                {
                    // TECH ROOM: DESK DRAWER
                    hasBrokenKey = true;
                    pbxBrokenKey.Visible = true;

                    lblText.Text += "\nYou open the drawer and find an old rusty key that acts as a backup key to the main office. \"Perhaps the office would be a \r\ngood place to check to figure out what's going on.\" You pocket the key and then question how long it's been since the school\r\nhas changed their locking mechanisms. ";
                    options = new string[2] { "OK", "BACK" };
                    positions = new int[2] { 0, 0 };
                }
                else if (position == 2)
                {
                    // TECH ROOM: ASSIGNMENT HAND-IN 
                    lblText.Text += "\nYou take a closer inspection of the hand-in basket. It appears only your prized students Aidan and Nick have bothered to \r\nhand anything in. You remind yourself to give them both 1000000000% on their next quiz. ";
                    options = new string[2] { "OK", "BACK" };
                    positions = new int[2] { 0, 0 };
                }
                else if (position == 3)
                {
                    // SOUTHERN BLOCK
                    lblText.Text = "\nYou close the door behind you and re-enter the Southern Block on the school. Scanning the various hallways, you notice a few\r\npoints of interest; a STAIRCASE leading upstairs, a POWER MECHANICS ROOM, a WELDING ROOM, and a HAIRSTYLING ROOM. You can \r\nalso go north to the NORTHERN BLOCK. ";
                    options = new string[5] { "STAIRCASE", "POWER MECHANICS ROOM", "WELDING ROOM", "HAIRSTYLING ROOM", "NORTHERN BLOCK" };
                    positions = new int[5] { 4, 8, 10, 12, 14 };
                }
                else if (position == 4)
                {
                    // SOUTHERN STAIRCASE
                    lblText.Text = "\nYou approach the SOUTHERN STAIRWELL, you notice a 1-inch thick strand of CAUTION tape blocks your way forward up the stairs.\r\nYou contemplate stepping over it, but then think there must be a more complicated and puzzle-based way upstairs. You also\r\nnotice a VENDING MACHINE to your right.";
                    options = new string[4] { "SOUTHERN BLOCK", "BACK", "VENDING", "MACHINE" };
                    positions = new int[4] { 3, 3, 5, 5 };
                }
                else if (position == 5)
                {
                    // SOUTHERN STAIRCASE: VENDING MACHINE
                    lblText.Text += "\nExamining the machine, you find yourself to be quite thirsty. Notably, a bottle of PEPSI catches your eye. There must be a \r\nway to pay.";
                    options = new string[3] { "COIN", "SOUTHERN BLOCK", "BACK" };
                    positions = new int[3] { 6, 3, 3 };
                }
                else if (position == 6 && !hasCoin)
                {
                    // SOUTHERN STAIRCASE: VENDING MACHINE (WITHOUT COIN)
                    lblText.Text += "\nYou search your pockets for a coin, but unfortunately, you don't have any. You can return to the SOUTHERN BLOCK.";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 6 && hasCoin)
                {
                    // SOUTHERN STAIRCASE: VENDING MACHINE (WITH COIN)
                    lblText.Text += "\nYou insert the coin into the slot and watch the machine operate. To your misfortune, you see the bottle of PEPSI get stuck\r\nin the machine. If only you had some sort of long metal object. You could always KICK the machine to get the drink.";
                    options = new string[3] { "KICK", "SOUTHERN BLOCK", "BACK" };
                    positions = new int[3] { 7, 3, 3 };
                }
                else if (position == 7)
                {
                    // SOUTHERN STAIRCASE: VENDING MACHINE: DEATH
                    lblText.Text = "\nWith a forceful kick, you slam the machine backward with incredible force. The impact seems to have loosened a bottle of \r\nPEPSI, which is properly dispensed. In your victory, you don't notice the machine rebounding from the kick. It proceeds\r\nto promptly crush you with it's weight. PEPSI; LIVE FOR NOW.";
                    
                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 8 && !hasWrench && !hasWeldingKey)
                {
                    // POWER MECH ROOM (WITHOUT WRENCH)
                    lblText.Text = "\nOpening the dusty power mechanics room, you see various machines that don't particularly interest you. What IS of interest,\r\nhowever is a small iron box sealed with several large bolts. Shaking the box, you hear a small object inside. You could\r\nprobably remove the bolt if you had the right tool. ";
                    options = new string[2] { "SOUTHERN BLOCK", "BACK" };
                    positions = new int[2] { 3, 3 };
                }
                else if (position == 8 && hasWrench && !hasWeldingKey)
                {
                    // POWER MECH ROOM (WITH WRENCH)
                    lblText.Text = "\nOpening the dusty power mechanics room, you see various machines that don't particularly interest you. What IS of interest,\r\nhowever is a small iron box sealed with several large bolts. Shaking the box, you hear a small object inside. You could\r\nprobably remove the bolt if you had the right tool.";
                    options = new string[3] { "WRENCH", "SOUTHERN BLOCK", "BACK" };
                    positions = new int[3] { 9, 3, 3 };
                }
                else if (position == 8 && hasWeldingKey)
                {
                    // POWER MECH ROOM (WITH WRENCH)(WITH WELDING ROOM KEY)
                    lblText.Text = "\nOpening the dusty power mechanics room, you see various machines that don't particularly interest you. What IS of interest,\r\nhowever is a small iron box sealed with several large bolts. It has been pryed open and has been cleaned out. There is now\r\nnothing left of interest in this room.";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 9)
                {
                    // POWER MECH ROOM: DISMANTLE BOX
                    hasWeldingKey = true;
                    pbxWeldingKey.Visible = true;

                    lblText.Text += "\nUsing the Janitor's wrench, you remove the bolts from the small box. Prying open the sides, you find the elusive WELDING\r\nROOM KEY inside. You leave the room with the key in hand. You feel your quest is nearly over! ";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 10 && !hasWeldingKey)
                {
                    // WELDING ROOM (WITHOUT WELDING ROOM KEY)
                    lblText.Text = "\nYou jiggle the knob of the welding room, only to find it to be locked. Though you have a feeling it's nearby. You then \r\ndecide you'll head on back and come back later.";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 10 && hasWeldingKey)
                {
                    // WELDING ROOM (WITH WELDING ROOM KEY)
                    lblText.Text = "\nUsing the key you obtained in the small metal box, you open up the welding room ajar. Inside you find several WELDING \r\nMACHINES the could be of use.";
                    options = new string[4] { "WELDING", "MACHINES", "SOUTHERN BLOCK", "BACK" };
                    positions = new int[4] { 11, 11, 3, 3 };
                }
                else if (position == 11 && !hasChemicals)
                {
                    // WELDING ROOM: USE MACHINES (WITHOUT CHEMICALS)
                    lblText.Text += "\nPreparing your broken key, you fire up the WELDING TORCH. You then find out the torch still requires OXYGEN and ACETYLENE\r\nto function properly. Perhaps you'll return later once you take a close inspection of the CHEMISTRY LAB. *Wink* Wink* Nudge*\r\nNudge*.";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 11 && hasChemicals && !hasKey && hasBrokenKey)
                {
                    // WELDING ROOM: USE MACHINES (WITH CHEMICALS)
                    hasKey = true;
                    hasBrokenKey = false;
                    pbxKey.Visible = true;
                    pbxBrokenKey.Visible = false;

                    lblText.Text += "\nInserting the chemicals through the \"nozzle\" of the device, you quickly activate the device. In no time, the office key is\r\nbetter than new! Finally you can finish this frickin' game! You leave the room and head back to the hallways. The OFFICE is\r\nready for you now!";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 11 && hasChemicals && !hasKey && !hasBrokenKey)
                {
                    lblText.Text = "\nInserting the chemicals through the \"nozzle\" of the device, you quickly activate the device. You quickly realize that you do\r\nnot have the office key to repair. Why didn't you pick it up when you were in the TECH ROOM when you started the game. Shame\r\non you! How did I notice and you didn't? Well, it helps that I am Inspector Grosky and I am sexy! \"Are you quite sure of \r\nthat?\" *Intensely Flashes Badge* YOU DIE OF SECONDHAND EMBARRASSMENT.";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 11 && hasChemicals && hasKey)
                {
                    // WELDING ROOM: USE MACHINES (WITH CHEMICALS)(WITH KEY)
                    lblText.Text += "\nYou light up the welding torch and get to work. You quickly realize that the office key is already fixed and that you just\r\nlit the torch for no reason. Instead you melt a bunch of scrap metal together as badly as you can and leave them for the \r\nwelding teacher with student's names on them. That'll teach them!";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 12)
                {
                    // HAIRSTYLING ROOM
                    lblText.Text = "\nYou enter the Hairstyling room to be greeted by the smell of several hairsprays and perfumes. Entering the side rooms, you\r\nfind a pair of BARBER'S SCISSORS on one of the counters. Holding them in your hands, you think to yourself: Perhaps you\r\nshould perk up your hairstyle like all those other ruffians do nowadays.\r\nWhat do you think is rad these days? COMB-OVER, MOHAWK, MULLET, PONYTAIL, PIGTAILS, MUSHROOM CUT, SHAVE IT ALL";
                    options = new string[9] { "COMB-OVER", "MOHAWK", "MULLET", "PONYTAIL", "PIGTAILS", "MUSHROOM CUT", "SHAVE IT ALL", "SOUTHERN BLOCK", "BACK" };
                    positions = new int[9] { 13, 13, 13, 13, 13, 13, 13, 3, 3 };
                }
                else if (position == 13)
                {
                    // HAIRSTYLING ROOM: HAIRCUT
                    lblText.Text += "\nUsing the scissors and other barbery equipment, you snip yourself a brand-new look. Billy Ray won't know what hit 'em.";
                    options = new string[3] { "SOUTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 3, 3, 3 };
                }
                else if (position == 14)
                {
                    // NORTHERN BLOCK
                    lblText.Text = "\nYou stroll on down to Northern Block. Performing a spot-check of the various hallways, you see a few points of interest. A\r\nSTAIRWELL, a CAFETERIA, an ELEVATOR, a HEALTH ROOM and the most important area in the game: the OFFICE.";
                    options = new string[7] { "OFFICE", "STAIRWELL", "CAFETERIA", "HEALTH ROOM", "ELEVATOR", "SOUTHERN BLOCK", "BACK" };
                    positions = new int[7] { 15, 16, 24, 26, 31, 3, 3 };
                }
                else if (position == 15 && !hasKey)
                {
                    // OFFICE (WITHOUT KEY)
                    lblText.Text = "\nYou haven't fixed the Office Key yet!";
                    options = new string[3] { "NORTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 14, 14, 14 };
                }
                else if (position == 15 && hasKey)
                {
                    // OFFICE (WITH KEY)
                    lblText.Text = "\nEntering the key into the lock, you open the office door. At last you're here! Finally you can discover where everyone has\r\ndisappeared to. Searching through the various drawers, you find nothing unusual at first. Confused, you enter the principal's\r\noffice and investigate. All of a sudden, you see a circled date on the principal's calendar! Turns out this Friday is pizza\r\nday! Pizza day FTW!!!!!!!!!!11one1111. Wait, wasn't that yesterday? Looking more closely, you notice today's date is \r\nSaturday, February 31st. So it was Saturday all along, huh? Well. This is awkward. I guess you win? Yay? Ah well. At least\r\nyou have your regular hair. Oh wait. You don't. Hairstyle is " + hairstyle + ". CONGLATURATION!! YOU'RE WINNER! YOU SCORE IS: 0";

                    hasWon = true;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 16)
                {
                    // NORTHERN STAIRWELL
                    lblText.Text = "\nYou advance to the Northern Stairwell only to find a CAUTION: WET FLOOR prevents your way upstairs. However, another stairwell\r\nleading to the BASEMENT appears unblocked.";
                    options = new string[3] { "BASEMENT", "NORTHERN BLOCK", "BACK" };
                    positions = new int[3] { 17, 14, 14 };
                }
                else if (position == 17 && !hasCandlestick)
                {
                    // BASEMENT (WITHOUT CANDLESTICK)
                    lblText.Text = "\nYou descend the stairs and open the door to the BASEMENT only to discover that you can barely see two centiinches in front of\r\nyour face. Perhaps you should come back when you have something to help you illuminate the area.";
                    options = new string[3] { "NORTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 14, 14, 14 };
                }
                else if (position == 17 && hasCandlestick)
                {
                    // BASEMENT (WITH CANDLESTICK)
                    lblText.Text = "\nYou descend the stairs only to discover that you can barely see two milliyards in front of yourself. However, you remember to\r\nbring out your trusty CANDLESTICK and swiftly light it. With your newfound light source, you proceed through the dark \r\ncorridors and begin to take your routine spot-check of the area. As you are doing so, you hear footsteps and see a dark\r\nshadow approaching from around the corner in front of you. You notice a PILLAR is to your left as the shadow looms closer.\r\nWhat will you do? HIDE BEHIND PILLAR, CONFRONT THE SHADOW, or TALK TO THE SHADOW";
                    options = new string[3] { "HIDE", "CONFRONT", "TALK" };
                    positions = new int[3] { 18, 19, 20 };
                }
                else if (position == 18)
                {
                    // BASEMENT: HIDE BEHIND PILLAR
                    hasWrench = true;
                    pbxWrench.Visible = true;

                    lblText.Text += "\nYou hide behind the stone PILLAR safely out of view while THE SHADOW passes you without noticing. You see that it was the \r\nJanitor all along! He mumbles to himself quietly while he passes you. While he mumbles, he doesn't notice that he drops his\r\nWRENCH on the floor behind him. You quickly pick up the WRENCH and call for the Janitor to tell him he's dropped it, but the\r\nJanitor is nowhere to be found. You then proceed through the corridors to see what else there is to discover.";
                    options = new string[1] { "OK" };
                    positions = new int[1] { 21 };
                }
                else if (position == 19)
                {
                    // BASEMENT: CONFRONT THE SHADOW
                    hasWrench = true;
                    pbxWrench.Visible = true;

                    lblText.Text += "\nBracing yourself you run towards THE SHADOW and deck it straight in the face, it's unconscious body falling to the floor. \r\nExamining the body, you discover that it was actually the school's Janitor. Feeling guilty, you search the body for any sort\r\nof medical equipment. Finding a bandage, you place it over his nose. He'll be better in no time! You also notice his trusty\r\nWRENCH while searching him and decide to borrow it. He'll never know it was gone!";
                    options = new string[1] { "OK" };
                    positions = new int[1] { 21 };
                }
                else if (position == 20)
                {
                    // BASEMENT: TALK TO THE SHADOW
                    hasWrench = true;
                    pbxWrench.Visible = true;

                    lblText.Text += "\nFearlessly, you turn the corner and meet the shadow face-to-face. You then realize that the menacing shadow is no monster at\r\nall, but the school Janitor! He appears startled at first, but upon realizing it's you, he loosens up a bit. You ask him \r\nseveral questions about what is going on around the school. \"Beats me,\" the Janitor says, \"I just do the cleanup around here.\r\nI do know that you'll be able to find out if you enter the OFFICE though.\" \"Take this,\" he says as he hands you his trusty\r\nWRENCH. \"The spare WELDING ROOM KEY is in a locked box in the POWER MECH ROOM. You'll need this to get it open.\" \"If you've\r\ngot the necessary equipment on ya, you should be able to fix that busted OFFICE KEY of yours. Good luck.\" With that, he \r\ndisappears into the shadows.";
                    options = new string[1] { "OK" };
                    positions = new int[1] { 21 };
                }
                else if (position == 21)
                {
                    // BASEMENT: THE PIPES
                    lblText.Text += "\nYou proceed further through the corridors to discover several PIPES on the wall to your left. A small PASSAGE can be visible\r\nto your right. A WRENCH could be useful for these.";
                    options = new string[3] { "WRENCH", "LOOK", "PASSAGE" };
                    positions = new int[3] { 22, 23, 8 };
                }
                else if (position == 22)
                {
                    // BASEMENT: THE PIPES: USE WRENCH
                    lblText.Text += "\nUsing your newly-acquired WRENCH, you begin dismantling the pipes. You successfully dismantle one sturdy piece of PIPE and \r\npocket it. However, you find the entire school (along with yourself) explodes instantly. Perhaps LOOKING wouldn't have been\r\na bad idea.";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 23)
                {
                    // BASEMENT: THE PIPES: LOOK PIPES
                    lblText.Text += "\nLooking more closely at the pipes, you see a large sign above them reading \"CAUTION: GAS LINE\". Deciding it would be best to\r\nleave them be, you proceed through the small passage to your right.";
                    options = new string[1] { "OK" };
                    positions = new int[1] { 8 };
                }
                else if (position == 24 && !hasCoin)
                {
                    // CAFETERIA (WITH COIN)
                    lblText.Text = "\nYou enter the dimmed CAFETERIA. In the darkness, you spot a faint SHIMMER on the floor in front of you. Two different sets of\r\ndoors lead back to the NORTHERN BLOCK.";
                    options = new string[3] { "SHIMMER", "NORTHERN BLOCK", "BACK" };
                    positions = new int[3] { 25, 14, 14 };
                }
                else if (position == 24 && hasCoin)
                {
                    // CAFETERIA (WITHOUT COIN)
                    lblText.Text = "\nYou enter the dimmly lit CAFETERIA. There is nothing in here of much importance. You might as well just go back to the \r\nNORTHERN BLOCK where there is actually something to do.";
                    options = new string[3] { "NORTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 14, 14, 14 };
                }
                else if (position == 25)
                {
                    // CAFETERIA: GET SHIMMER
                    hasCoin = true;
                    pbxCoin.Visible = true;

                    lblText.Text = "\nYou bend down and pick up the small object. You discover it to be a Loonie. You pocket your lucky find. Long live Canadian \r\ncurrency!";
                    options = new string[3] { "NORTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 14, 14, 14 };
                }
                else if (position == 26 && !hasBungee)
                {
                    // HEALTH ROOM (WITHOUT BUNGEE)
                    lblText.Text = "\nYou open the door to the HEALTH ROOM and (to your surprise) find it unlocked. Inside you find several CPR TEST DUMMIES, and a\r\ndesk on which a SMAll RING BOX can be found.";
                    options = new string[9] { "BOX", "SMALL BOX", "RING BOX", "SMALL RING BOX", "DUMMIES", "TEST DUMMIES", "CPR TEST DUMMIES", "NORTHERN BLOCK", "BACK" };
                    positions = new int[9] { 27, 27, 27, 27, 28, 28, 28, 14, 14 };
                }
                else if (position == 26 && hasBungee)
                {
                    // HEALTH ROOM (WITH BUNGEE)
                    lblText.Text = "\nYou walk into the HEALTH ROOM but realize there is only one thing of importance. Do you remember what that is?";
                    options = new string[5] { "DUMMIES", "TEST DUMMIES", "CPR TEST DUMMIES", "NORTHERN BLOCK", "BACK" };
                    positions = new int[5] { 28, 28, 28, 14, 14 };
                }
                else if (position == 27)
                {
                    // HEALTH ROOM: GET BUNGEE
                    hasBungee = true;
                    pbxBungee.Visible = true;

                    lblText.Text += "\nYou pick up the small box and find it fits comfortably in your palm. You open it up to reveal Ms. Wood's BUNGEE EQUIPMENT \r\nkept inside. You always wondered why she brings this to every staff meeting. You then pocket the BUNGEE EQUIPMENT for later\r\nuse.";
                    options = new string[3] { "NORTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 14, 26, 26 };
                }
                else if (position == 28)
                {
                    // HEALTH ROOM: TEST DUMMIES OF DOOM
                    lblText.Text += "\nYou look at the CPR TEST DUMMIES. You notice one that reminds you of a CPR TEST DUMMY. A note can be found on one of the \r\ndummies that reminds you of a note on a CPR TEST DUMMY. Reading it, it reminds you of remembering to be reminded that CPR\r\nTEST DUMMIES look like CPR TEST DUMMIES and notes look like notes. Also, you then remember about this one time you went into\r\na school alone and entered a HEALTH ROOM that had CPR TEST DUMMIES. When you looked at those CPR TEST DUMMIES, it reminded\r\nyou of CPR TEST DUMMIES. You also remember that a NOTE could be FOUND on ONE that reminded you that some WORDS are in \r\nCAPTIAL LETTERS. Can you REMEMBER those CPR TEST DUMMIES?";
                    options = new string[6] { "REMEMBER", "DUMMIES", "TEST DUMMIES", "CPR TEST DUMMIES", "NORTHERN BLOCK", "BACK" };
                    positions = new int[6] { 29, 29, 29, 29, 14, 26 };
                }
                else if (position == 29)
                {
                    // HEALTH ROOM: REMEMBER TEST DUMMIES OF DOOM
                    lblText.Text += "\nYou then remember about one time you remembered to remember. Press 1 to go back. Remember where that is? Remember, the Force\r\nwill be with you, always. Forgot? Let me tell you again. Once there was a crooked man who walked a crooked mile. He found a \r\ncrooked sixpence upon a crooked stile. Why is the text underline of stile blue? Frickin' Microsoft Word. \r\nPress 1 to remember NORTHERN BLOCK. Remember where that is?";
                    options = new string[1] { "" };
                    positions = new int[1] { 30 };
                    position = 30;
                }
                else if (position == 30)
                {
                    // PSYCHOTIC WARD: DEATH
                    lblText.Text = "\nYo shit for brains, what goddamn colour is this? Stop ye-LLING! IT'S BLUE!! Looking good Whoopi! *double snap and finger guns*\r\nDo you see a clue? You remember what a clue is. But do you remember what a clue looks like? Wait, do you remember anything? \r\nGuess not, you lost your mind somewhere along the line. You lost it back when you were looking at...wait, what were you \r\nlooking at? Oh no, am I losing my mind too?! NOOOOOOOOOOOOOOOOOOOOOOOOO!!!! GAME OVER, UNIVERSE DESTROYED";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 31)
                {
                    if (elevatorVisits == 1)
                    {
                        // ELEVATOR (FIRST VISIT)
                        lblText.Text = "\nYou press the button to call the elevator and wait for it to arrive. Days turned into years, and into centuries, patience had\r\nto fade. Don't you see that there is vengeance in my eyes? You then then then then rip the doors open with your bare hand. \r\nShaking off the dust of the disintegrated door, you look inside to find out that the elevator is not even in there. Looking \r\ndown, you see the Earth's core looking up at you. You see a small POLE that an elevator would slide up and down.";
                    }
                    else if (elevatorVisits == 2)
                    {
                        // ELEVATOR (SECOND VISIT)
                        lblText.Text = "\nHey, look! I said LOOK!! There's no elevator, but I guess you remember that from last time. Maybe you do or maybe you don't. \r\nYou could've just breezed right through the dialog without reading, like you don't even care. Down that shaft is Hell. Don't \r\nbelieve me, then go check the original dialog. Oh wait, you can't? Well, I guess you're just gonna have to take my word for\r\nit. \r\n\r\nYou spot the disintegrated door. Hot damn, you are strong! And all you needed was your bare hand. Beyond that is the ELEVATOR\r\nshaft with a small POLE that an elevator would slide up and down on.";
                    }
                    else
                    {
                        // ELEVATOR (SUBSEQUENT VISITS)
                        lblText.Text = "\nYou have visited the elevator " + elevatorVisits + " times, do you have a life?\n\nYou spot the disintegrated door. Hot damn, you are strong! And all you needed was your bare hand. Beyond that is the ELEVATOR\r\nshaft with a small POLE that an elevator would slide up and down on.";
                    }
                    elevatorVisits++;

                    options = new string[4] { "CLIMB", "POLE", "NORTHERN BLOCK", "BACK" };
                    positions = new int[4] { 32, 32, 14, 14 };
                }
                else if (position == 32 && !hasBungee)
                {
                    // ELEVATOR: CLIMB POLE (WITHOUT BUNGEE): DEATH
                    lblText.Text += "\nYou leap towards the pole and grasp it firmly. You begin to scale the pole, but find that someone has applied BUTTER to the\r\nhigher section of the pole. Your hands slip and cause you to accidentally snap the pole in half with your bare finger. With\r\nnothing left to grab onto, you fall into the abyss below. If only it was margarine...";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 32 && hasBungee)
                {
                    // ELEVATOR: CLIMB POLE (WITH BUNGEE)
                    lblText.Text += "\nYou fish through your pockets and pull out the 12 ft. BUNGEE EQUIPMENT. Swinging it around like Indiana Jones in a circus \r\ntrain, you whip it good and attach it to the small landing above. Safely climbing upside-down up the pole, you safely \r\nreach the second floor. *Fistbump*";
                    options = new string[1] { "OK" };
                    positions = new int[1] { 33 };
                }
                else if (position == 33)
                {
                    // WESTERN BLOCK
                    lblText.Text = "\nUsing your amazing detective skills, you take a scan of the second floor. You are currently in the WESTERN BLOCK. You \r\nnote a small JANITOR'S CLOSET, a CHEMISTRY LAB, and you also note a MATH ROOM to your left. You also notice that there\r\nis an EASTERN BLOCK. So there.";
                    options = new string[10] { "NORTHERN BLOCK", "POLE", "BACK", "CHEMISTRY LAB", "LAB", "JANITOR'S CLOSET", "JANITORS CLOSET", "CLOSET", "MATH ROOM", "EASTERN BLOCK" };
                    positions = new int[10] { 49, 49, 49, 34, 34, 38, 38, 38, 42, 45 };
                }
                else if (position == 34 && !hasChemicals)
                {
                    // CHEMISTRY LAB (WITHOUT CHEMICALS)
                    lblText.Text = "\nEntering the dimly dim CHEMISTRY LAB you see several concoctions brewing in small vials. You see several highly acidic \r\ncompounds on a rickety table near the western end of the room. Beyond the table, you see two large VATS labelled: \"Oxygen\" \r\nand \"Acetylene\". You can approach the VATS from the LEFT or RIGHT. On the teacher's desk, you see a bowl of CHEERIOS with no \r\nmilk and a STYROFOAM CUP with what appears to be an opaque white liquid.";
                    options = new string[7] { "CHEERIOS", "STYROFOAM", "CUP", "LEFT", "RIGHT", "WESTERN BLOCK", "BACK" };
                    positions = new int[7] { 35, 35, 35, 36, 37, 33, 33 };
                }
                else if (position == 34 && hasChemicals)
                {
                    // CHEMISTRY LAB (WITH CHEMICALS)
                    lblText.Text = "\nYou look at the CHEMISTRY LAB door and remember that you already have the necessary equipment from this room. Why the hell \r\nwould you want to go back?";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 33, 33 };
                }
                else if (position == 35)
                {
                    // CHEMISTRY LAB: PREPARE CHEERIOS
                    lblText.Text += "\nYou take a spoonful of Cheerios but find that they're just not the same dry. You pick up the small STYROFOAM CUP and pour the\r\nliquid into the bowl. Pouring the contents of the cup into the bowl, you notice the Cherrios are promptly incinerated. Putting\r\nthe spoon into the bowl, you notice the head of the spoon is promptly melted in a matter of milliseconds. Without a spoon to\r\neat the contents of the bowl, you instead sip straight from the bowl, only to find your insides are promptly incinerated. \r\nWhat else did you expect from LIQUID CARBON?";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 36)
                {
                    // CHEMISTRY LAB: APPROACH VATS FROM LEFT
                    lblText.Text += "\nYou approach the VATS from the left only to accidentally knock over the small rickety table of incredibly dangerous chemicals;\r\nAqua Regia, Sulfuric Acid, Sodium Hydroxide, Nitroglycerin and Flintstones gummy vitamins. They proceed to kill you dead. But\r\nat least the gummies were tasty! Optimism. Who says the glass is half full?";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 37)
                {
                    // CHEMISTRY LAB: APPROACH VATS FROM RIGHT
                    hasChemicals = true;
                    pbxChemicals.Visible = true;

                    lblText.Text += "\nYou approach the VATS from the right like a good little chap would. Good idea you didn't go past that incredibly unstable \r\nrickety table. You quickly fit the 30-gallon VATS of CHEMICALS into your pocket. Looks like you're set for welding! You \r\nleave the room and lock the door behind you.";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 33, 33 };
                }
                else if (position == 38 && !hasCandlestick)
                {
                    // JANITOR'S CLOSET (WITHOUT CANDLESTICK)
                    lblText.Text = "\nYou open the small JANITOR'S CLOSET and peek inside. You see several items on various shelves. Of note is a CANDLESTICK, a \r\nsmall NOTE, and a clear SAFE labeled: \"Useful inventory items\".";
                    options = new string[5] { "NOTE", "SAFE", "CANDLE", "WESTERN BLOCK", "BACK" };
                    positions = new int[5] { 39, 40, 41, 33, 33 };
                }
                else if (position == 38 && hasCandlestick)
                {
                    // JANITOR'S CLOSET (WITH CANDLESTICK)
                    lblText.Text = "\nReturning to the JANITOR'S CLOSET, you see a small NOTE, and a clear SAFE labelled: \"Useful inventory items\" on the front-\r\nhand side.";
                    options = new string[4] { "NOTE", "SAFE", "WESTERN BLOCK", "BACK" };
                    positions = new int[4] { 39, 40, 33, 33 };
                }
                else if (position == 39)
                {
                    // JANITOR'S CLOSET: LOOK NOTE
                    lblText.Text += "\nYou pick up the small note and give it a read. It says: \"Gone to BASEMENT to fix loose pipes; will return WRENCH when \r\nfinished.\" - Janitor. BASEMENT and WRENCH, eh? That's definitely not useful information. Though why would the Janitor leave a\r\nnote for himself in his own closet? Now that's a real mystery! Also, why did he capitalize all of basement and wrench? Seems\r\nlike an odd man, or just likes to break the fourth wall. Who knows? Only God!";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 38, 38 };
                }
                else if (position == 40)
                {
                    // JANITOR'S CLOSET: LOOK SAFE
                    lblText.Text += "\nYou look at the large SAFE and discover it's locked with a 72-digit passcode. You peer through the clear glass and discover \r\nthe Janitor's trusty REVOLVER, his ROCKET LAUNCHER, a small bottle of ANALGESIC, a SKELETON KEY, an ELEVATOR CLIMBING KIT, a\r\n12-case of PEPSI, a LONG METAL OBJECT, a FLASHLIGHT, a KEY REPAIR KIT, a spare OFFICE KEY, several TINDERBOXES, \r\nTHERMOWEAVE UNDERWEAR, a HAZMAT SUIT, the Janitor's pet rock ROCKINGTON, and a 394-page BOOK entitled: \"The code to this safe\r\nis in here.\" You take a few guesses as to what the passcode is, but are all in vain. You give up at\r\n000000000000000000000000000000000000000000000000000000000000000000000009";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 38, 38 };
                }
                else if (position == 41)
                {
                    // JANITOR'S CLOSET: GET CANDLESTICK
                    hasCandlestick = true;
                    pbxCandlestick.Visible = true;

                    lblText.Text += "\nYou pick up the CANDLESTICK and shove it in your pocket. This could come in handy for investigating those oh-so dark areas.";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 38, 38 };
                }
                else if (position == 42 && !hasSledgehammer)
                {
                    // MATH ROOM (WITHOUT SLEDGEHAMMER)
                    lblText.Text = "\nYou enter the MATH ROOM and discover a largely small TEXTBOOK on one desk. You also see a SLEDGEHAMMER snuggly put in a small\r\ncup on the desk to your right's left. ";
                    options = new string[4] { "TEXTBOOK", "SLEDGEHAMMER", "WESTERN BLOCK", "BACK" };
                    positions = new int[4] { 43, 44, 33, 33 };
                }
                else if (position == 42 && hasSledgehammer)
                {
                    // MATH ROOM (WITH SLEDGEHAMMER)
                    lblText.Text = "\nLooking again at the MATH ROOM, you spot a small TEXTBOOK on one desk, and an exit leading back to the WESTERN BLOCK.";
                    options = new string[3] { "TEXTBOOK", "WESTERN BLOCK", "BACK" };
                    positions = new int[3] { 43, 33, 33 };
                }
                else if (position == 43)
                {
                    // MATH ROOM: LOOK TEXTBOOK
                    lblText.Text += "\nYou pick up the textbook and begin to read. Page after page you begin to understand less and less. You begin to yawn when you\r\nread about \"Simplifying simplified simpler fractions in an overly complicated manner\". You begin to question when would \r\nanyone would use this useless information in their lives. You then pity those who actually need to know this kind of \r\ninformation for their horrendous line of work. As the book continues, you notice something about \"Factoring factors in a \r\nuseless and overcomplicated manner that will probably cause most of you to fail: For beginners\". As you look at the shelf to\r\nyour side, you see the second edition of this book \"Calculus: Second Edition: Twice as big, Twice as pointless in your known\r\nlifetime\". You then feel a feeling of overwhelming worthlessness, pondering the meanings of life and our own insignificance.\r\nWhy was something like this ever conceived? What is the point? Why am I here? Are we alone in the universe? Why are all my \r\nthoughts within an amateur text-adventure coded by 11th graders, then remastered by one of those 11th graders when he was 25\r\njust so he could give his friend a birthday gift? Upon realizing the existence of your world does not exist and lies within\r\nthe hands of two 11th graders, and then redone by one of them at 25 who still has the mentality of a child, you then die an\r\novercomplicated death. YOU AND YOUR FRIENDS ARE DEAD.";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 44)
                {
                    // MATH ROOM: GET SLEDGEHAMMER
                    hasSledgehammer = true;
                    pbxSledgehammer.Visible = true;

                    lblText.Text += "\nYou pick up the SLEDGEHAMMER and slide it snuggly into your side pocket. Abe Lincoln won't know what hit 'em.";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 42, 42 };
                }
                else if (position == 45 && !hasLooseleaf)
                {
                    // EASTERN BLOCK (WITHOUT LOOSELEAF)
                    lblText.Text = "\nLooking around the EASTERN BLOCK, you notice all of the doors on this side of the school are locked. You do however, notice a\r\nsmall piece of LOOSELEAF on the floor in front of you. Beyond the sheet lies what appears to be a shortcut back to the \r\nWESTERN BLOCK.";
                    options = new string[3] { "LOOSELEAF", "WESTERN BLOCK", "BACK" };
                    positions = new int[3] { 47, 48, 48 };
                }
                else if (position == 45 && hasLooseleaf)
                {
                    // EASTERN BLOCK (WITH LOOSELEAF)
                    lblText.Text = "\nWhy did you come back here? You already did what was required for this area. Go away!";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 33, 33 };
                }
                else if (position == 46)
                {
                    // EASTERN BLOCK: FORESIGHT
                    lblText.Text += "\nLooking around the EASTERN BLOCK, you notice all of the doors on this side of the school are locked. There was a piece of \r\nLOOSELEAF here, but it's been removed by someone who clearly is thinking straight. Good on you! Sucks there's nothing else \r\nhere but that!";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 33, 33 };
                }
                else if (position == 47)
                {
                    // EASTERN BLOCK: GET LOOSELEAF
                    hasLooseleaf = true;
                    pbxLooseleaf.Visible = true;

                    lblText.Text += "\nYou pick up the sheet of LOOSELEAF to discover it reads: \"BEWARE: PICK THIS UP OR YOU'LL DIE\". Good thing you read it before\r\nyou went back, huh?";
                    options = new string[3] { "WESTERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 33, 46, 46 };
                }
                else if (position == 48)
                {
                    // EASTERN BLOCK: SLIP ON LOOSELEAF
                    lblText.Text += "\nYou attempt to proceed back to the WESTERN BLOCK, only to slip on the sheet of LOOSELEAF lying on the floor in front of you \r\nand kill yourself. With your last breath, you look on the sheet of paper to discover it reads: \"BEWARE: PICK THIS UP OR \r\nYOU'LL DIE\". Reading: It's not just for nerds anymore.";

                    isAlive = false;
                    position = 0;
                    storyChapter(position);
                }
                else if (position == 49)
                {
                    // EXIT SECOND FLOOR
                    lblText.Text += "\nYou deftly launch yourself back through the elevator shaft and swing yourself around the POLE like you're goddamn Spider-Man! \r\nThat BUNGEE EQUIPMENT that Ms. Woods carries around is amazing, some would even say spectacular. You swing yourself right \r\nthrough to the first floor. Noice! *High-Five*";
                    options = new string[3] { "NORTHERN BLOCK", "OK", "BACK" };
                    positions = new int[3] { 14, 14, 14 };
                }
            }
            else
            {
                if (hasWon)
                {
                    lblText.Text += "\n\nYou won! Do you want to play again?";
                    options = new string[2] { "YES", "NO" };
                    positions = new int[2] { 0, 0 };
                }
                else
                {
                    lblText.Text += "\n\nGAME OVER\n\nTry again?";
                    options = new string[2] { "YES", "NO" };
                    positions = new int[2] { 0, 0 };
                }
            }
        }
    }
}