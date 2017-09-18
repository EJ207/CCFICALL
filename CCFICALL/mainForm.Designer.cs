namespace CCFICall
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnCall = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_timer = new System.Windows.Forms.Timer(this.components);
            this.btnHangup = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTestAction = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.phoneSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRD = new System.Windows.Forms.Button();
            this.cBCall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBStore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnhold = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.btnHeadset = new System.Windows.Forms.Button();
            this.btnVolDn = new System.Windows.Forms.Button();
            this.btnVolUp = new System.Windows.Forms.Button();
            this.cbTransfer = new System.Windows.Forms.ComboBox();
            this.brnTransfer = new System.Windows.Forms.Button();
            this.btnUnmute = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(182, 12);
            this.btnCall.Margin = new System.Windows.Forms.Padding(4);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(121, 33);
            this.btnCall.TabIndex = 1;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsLbl
            // 
            this.stsLbl.Name = "stsLbl";
            this.stsLbl.Size = new System.Drawing.Size(26, 17);
            this.stsLbl.Text = "Idle";
            // 
            // m_timer
            // 
            this.m_timer.Interval = 2500;
            this.m_timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // btnHangup
            // 
            this.btnHangup.Location = new System.Drawing.Point(182, 52);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.Size = new System.Drawing.Size(121, 27);
            this.btnHangup.TabIndex = 15;
            this.btnHangup.Text = "End Call";
            this.btnHangup.UseVisualStyleBackColor = true;
            this.btnHangup.Click += new System.EventHandler(this.btnHangup_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(86, 50);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 23);
            this.btnHold.TabIndex = 16;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(86, 21);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 17;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 21);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(155, 218);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 23);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "Test Action";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTestAction
            // 
            this.txtTestAction.Location = new System.Drawing.Point(17, 218);
            this.txtTestAction.Name = "txtTestAction";
            this.txtTestAction.Size = new System.Drawing.Size(132, 22);
            this.txtTestAction.TabIndex = 20;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(310, 12);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(85, 33);
            this.btnAnswer.TabIndex = 21;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneSettingsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Options";
            // 
            // phoneSettingsToolStripMenuItem
            // 
            this.phoneSettingsToolStripMenuItem.Name = "phoneSettingsToolStripMenuItem";
            this.phoneSettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.phoneSettingsToolStripMenuItem.Text = "Settings";
            this.phoneSettingsToolStripMenuItem.Click += new System.EventHandler(this.phoneSettingsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRD);
            this.groupBox1.Controls.Add(this.cBCall);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBStore);
            this.groupBox1.Controls.Add(this.btnAnswer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCall);
            this.groupBox1.Controls.Add(this.btnHangup);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 97);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Call";
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(309, 52);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(86, 27);
            this.btnRD.TabIndex = 22;
            this.btnRD.Text = "Redial";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // cBCall
            // 
            this.cBCall.AutoCompleteCustomSource.AddRange(new string[] {
            "5025551234",
            "4191236541",
            "6143219876"});
            this.cBCall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBCall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBCall.FormattingEnabled = true;
            this.cBCall.Items.AddRange(new object[] {
            "614-863-2522",
            "614-478-4040",
            "614-575-9780",
            "740-362-4081",
            "614-291-4100",
            "614-276-3334",
            "614-445-6669",
            "937-324-9111",
            "614-882-2217",
            "937-847-2800",
            "937-254-7800",
            "937-854-3392",
            "937-236-4988",
            "614-274-9338",
            "740-689-9333",
            "614-527-4444",
            "513-727-4566",
            "614-751-1314",
            "513-481-3222",
            "740-788-8631",
            "513-598-9551",
            "513-942-9977",
            "740-450-7720",
            "513-202-1900",
            "513-931-7300",
            "513-936-9995",
            "513-831-4455",
            "937-642-1664",
            "859-727-4569",
            "859-647-7500",
            "513-929-4155",
            "513-281-5490",
            "859-581-8400",
            "614-764-1110",
            "561-242-0408",
            "937-372-8018",
            "561-863-7141",
            "513-947-9551",
            "859-291-2666",
            "727-522-5309",
            "216-362-1006",
            "216-475-1580",
            "216-941-6329",
            "513-741-3777",
            "440-602-9922",
            "216-351-3366",
            "602-841-3393",
            "623-247-6200",
            "440-392-2274",
            "480-981-6999",
            "440-842-0333",
            "602-297-9777",
            "954-784-0013",
            "954-763-1400",
            "305-836-1200",
            "480-966-1771",
            "216-226-4066",
            "330-922-4779",
            "859-823-2222",
            "614-851-3230",
            "419-476-8785",
            "419-382-5385",
            "614-985-3509",
            "216-360-9940",
            "662-229-9997",
            "804-232-3533",
            "757-484-5600",
            "757-558-9444",
            "602-248-9553",
            "602-896-9700",
            "623-873-3900",
            "602-272-8688",
            "757-583-8100",
            "216-587-5631",
            "440-442-7345",
            "614-860-1181",
            "757-938-9933",
            "513-731-8200",
            "513-772-4520",
            "513-471-0548",
            "216-714-4324",
            "216-531-1574",
            "216-739-0837",
            "216-289-8462",
            "330-753-0377",
            "216-663-3240",
            "513-895-2100",
            "513-797-1600",
            "419-472-5007",
            "330-940-3271",
            "440-842-0426",
            "804-359-9388",
            "440-269-1318",
            "480-917-3100",
            "662-240-9782",
            "520-746-3200",
            "520-434-2700",
            "757-848-1041",
            "757-486-5666",
            "330-785-3161",
            "520-751-0300",
            "662-680-9233",
            "734-495-0523",
            "480-668-0300",
            "937-428-7530",
            "734-281-1474",
            "313-299-7784",
            "813-983-9623",
            "216-206-2558",
            "513-851-3100",
            "520-622-5600",
            "859-426-5196",
            "623-245-1200",
            "623-334-0007",
            "520-546-6100",
            "757-365-9711",
            "757-622-2210",
            "614-577-1145",
            "614-237-8196",
            "480-635-1400",
            "602-404-1900",
            "330-544-6017",
            "480-775-1700",
            "480-357-3100",
            "440-734-2749",
            "502-810-0861",
            "480-396-6700",
            "480-668-6500",
            "623-936-9400",
            "330-753-0628",
            "330-832-5308",
            "502-447-5200",
            "937-294-0500",
            "602-237-8700",
            "520-790-2600",
            "440-363-4288",
            "601-924-8686",
            "574-289-6647",
            "574-287-8745",
            "574-259-5888",
            "574-294-5906",
            "574-533-9952",
            "260-496-8885",
            "260-496-8875",
            "317-280-1439",
            "317-782-4400",
            "317-353-0700",
            "317-890-1800",
            "260-456-3338",
            "317-576-8004",
            "317-541-0640",
            "317-270-9332",
            "317-337-1201",
            "317-890-1990",
            "317-252-0690",
            "317-888-0011",
            "812-288-4209",
            "317-837-1185",
            "330-966-1752",
            "614-837-2556",
            "757-539-7878",
            "330-477-7867",
            "520-295-1788",
            "602-864-0900",
            "602-224-9900",
            "502-935-9905",
            "937-567-1450",
            "734-946-0672",
            "734-261-2318",
            "734-261-3857",
            "502-969-0026",
            "330-743-1568",
            "502-447-4744",
            "740-389-2097",
            "937-325-4000",
            "502-361-9200",
            "513-868-2400",
            "925-609-8161",
            "925-776-1300",
            "707-399-0434",
            "510-352-0640",
            "510-337-3940",
            "510-739-0150",
            "707-557-4522",
            "916-429-1971",
            "916-486-1834",
            "916-643-2274",
            "408-286-5055",
            "916-265-2884",
            "419-625-3100",
            "330-758-4201",
            "502-961-8554",
            "513-761-6003",
            "650-794-1234",
            "510-537-2274",
            "510-232-9975",
            "419-528-1315",
            "419-424-3164",
            "786-621-4748 ",
            "305-362-1726",
            "601-992-0016",
            "305-752-9555 ",
            "305-644-1840 ",
            "601-207-1797",
            "662-378-3848",
            "601-894-4092",
            "804-733-1750",
            "757-461-1680",
            "804-501-2413",
            "586-792-4519",
            "586-757-8995",
            "313-278-2508",
            "586-771-3445",
            "734-485-6248",
            "248-666-5940",
            "248-972-0810",
            "313-245-9560",
            "205-781-9171",
            "205-413-4478",
            "205-660-2400",
            "205-413-4460",
            "256-739-0497",
            "205-330-0913",
            "205-366-0140",
            "205-923-3762",
            "205-942-0001",
            "205-437-1515",
            "205-956-2424",
            "334-293-9999",
            "205-397-1200",
            "334-558-9000",
            "205-745-4175",
            "205-591-0800",
            "205-552-0010",
            "205-769-3800",
            "205-639-5858",
            "334-273-0354",
            "334-288-8865",
            "251-308-7015",
            "251-308-7023",
            "601-428-5950",
            "615-445-2323",
            "772-879-4000",
            "561-642-9629",
            "786-454-9686",
            "205-221-4991",
            "256-547-5600",
            "928-782-0709",
            "928-428-0014",
            "510-728-9201",
            "408-847-6028",
            "559-252-6600",
            "559-227-7795",
            "310-644-2525",
            "562-804-4497",
            "760-946-1093",
            "559-589-1750",
            "760-843-5500",
            "909-829-2311",
            "760-398-0350",
            "909-792-8816",
            "949-498-5470",
            "951-245-3418",
            "951-867-3009",
            "951-925-9909",
            "760-770-4458",
            "760-351-1100",
            "951-849-5319",
            "951-487-2967",
            "951-360-9333",
            "559-733-4288",
            "661-299-6755",
            "661-940-9909",
            "661-831-4534",
            "408-238-4696",
            "408-578-1150",
            "408-730-5505",
            "510-887-7440",
            "408-980-1000",
            "415-391-2274",
            "408-923-1331",
            "831-753-2274",
            "408-926-2274",
            "559-875-9922",
            "559-224-7135",
            "559-297-6700",
            "408-247-0678",
            "408-559-0777",
            "408-229-1333",
            "650-548-4700",
            "408-926-5626",
            "559-261-0300",
            "408-262-2274",
            "559-227-1400",
            "559-248-0700",
            "559-636-8700",
            "510-532-7637",
            "415-863-6755",
            "415-641-4003",
            "510-536-7887",
            "510-777-0761",
            "408-866-7575",
            "408-244-7575",
            "408-287-0990",
            "650-368-1118",
            "831-899-8600",
            "510-790-2936",
            "408-292-8090",
            "559-251-2040",
            "209-829-0739",
            "707-664-0364",
            "707-546-2274",
            "707-579-2274",
            "831-761-3776",
            "707-648-2825",
            "916-422-2435",
            "510-475-1110",
            "916-736-9900",
            "925-803-1401",
            "916-983-2229",
            "916-691-2520",
            "209-745-8815",
            "209-223-9268",
            "510-727-9889",
            "925-682-2242",
            "510-527-2274",
            "510-732-9393",
            "650-873-1557",
            "510-865-8844",
            "925-682-6201",
            "925-439-7667",
            "925-370-8180",
            "925-458-3210",
            "510-547-0859",
            "510-276-2426",
            "925-778-6600",
            "510-233-5190",
            "415-239-4000",
            "323-778-1200",
            "562-491-6500",
            "310-835-6267",
            "818-781-7011",
            "323-560-0071",
            "323-725-1493",
            "323-462-2566",
            "310-263-7676",
            "818-759-7072",
            "661-538-1887",
            "661-945-6900",
            "818-899-2749",
            "323-258-2606",
            "209-474-2281",
            "209-941-2274",
            "209-952-6644",
            "530-671-7696",
            "209-941-0629",
            "209-823-4000",
            "916-332-0412",
            "916-721-8400",
            "916-646-6776",
            "209-823-2222",
            "209-836-2274",
            "209-833-2274",
            "916-722-3495",
            "530-626-4888",
            "530-532-1900",
            "707-425-1400",
            "707-455-0146",
            "530-879-9500",
            "209-943-2274",
            "209-369-7296",
            "916-392-2435",
            "916-368-2274",
            "916-424-7296",
            "916-731-7296",
            "916-973-1570",
            "209-478-3530",
            "916-454-6185",
            "916-773-2274",
            "916-641-2274",
            "916-726-2275",
            "209-578-2727",
            "530-669-1333",
            "925-447-2274",
            "916-428-1100",
            "916-368-6600",
            "503-533-8865",
            "503-371-5456",
            "209-222-3761",
            "256-286-2610",
            "256-274-8166",
            "423-933-3750",
            "757-320-4956 ",
            "757-506-0006",
            "209-248-4966",
            "865-622-5934",
            "859-912-7350",
            "601-693-0006",
            "601-261-6106",
            "601-463-5626",
            "601-202-2631",
            "228-467-6640",
            "601-928-2808",
            "228-769-6745",
            "757-849-0570",
            "256-403-2420",
            "615-823-7855",
            "818-505-8585",
            "615-823-7866",
            "757-644-3774",
            "256-217-5980",
            "865-686-5737",
            "256-203-7070",
            "256-203-7041",
            "615-823-7850",
            "931-538-1411",
            "615-913-4166",
            "931-542-4811",
            "865-333-7003",
            "334-523-7020",
            "334-489-7000",
            "502-812-1234",
            "423-805-9177",
            "423-805-9161",
            "251-476-2978",
            "251-343-7070",
            "251-643-7334",
            "786-501-7900",
            "205-409-0370",
            "901-327-7779",
            "901-360-8883",
            "901-767-5834",
            "901-375-4677",
            "901-383-4117",
            "334-635-1222",
            "865-366-0212",
            "256-403-2400",
            "615-203-7000",
            "615-781-2615",
            "757-319-4244",
            "530-899-0789",
            "757-544-9292",
            "205-564-7000",
            "423-491-7100",
            "559-438-6669",
            "423-398-7012",
            "731-736-7000",
            "434-439-7007",
            "251-308-7007",
            "757-319-4190",
            "540-795-7022",
            "804-292-7117",
            "540-795-7030",
            "757-215-4206",
            "626-794-9239",
            "626-343-9342",
            "559-224-5680",
            "662-746-1313",
            "601-544-3005",
            "601-948-4663",
            "601-362-1477",
            "419-537-1346",
            "419-475-1926",
            "662-534-2027",
            "662-890-7891",
            "662-280-0469",
            "662-846-0680",
            "662-887-6262",
            "662-840-0608",
            "662-453-1947",
            "662-283-3320",
            "662-247-4545",
            "601-825-7791",
            "601-859-2274",
            "601-892-9000",
            "662-834-1278  ",
            "601-867-3814",
            "601-853-2401",
            "601-661-0888",
            "601-933-1910",
            "601-373-6115",
            "601-482-5574",
            "662-773-8611",
            "601-579-6700",
            "601-765-4540",
            "601-731-5988",
            "601-649-0333",
            "601-947-3223",
            "601-798-4490",
            "228-214-4424",
            "228-396-4546",
            "228-818-3223",
            "228-762-3800",
            "601-835-1010",
            "601-250-1957",
            "601-876-3250",
            "662-327-9666",
            "662-324-2120",
            "662-258-3001",
            "662-494-0880",
            "602-347-6595",
            "480-421-5777",
            "480-454-7280",
            "623-435-4062",
            "623-474-9614",
            "480-454-7275",
            "520-903-6932",
            "480-874-7321",
            "623-463-8688",
            "480-448-7383",
            "623-463-8591",
            "480-376-8866",
            "480-454-7240",
            "480-874-7326",
            "623-223-9277",
            "602-783-8855",
            "520-903-6924",
            "520-903-6928",
            "602-753-5660",
            "602-753-5595",
            "916-304-8180",
            "916-382-0270",
            "669-244-1970",
            "916-277-0440",
            "559-330-1150",
            "510-324-9200",
            "323-621-6947",
            "818-457-3997",
            "323-621-6951",
            "323-489-8122",
            "661-234-8100",
            "818-934-8986",
            "209-252-0826",
            "916-400-9990",
            "707-344-9780",
            "209-425-4200",
            "916-250-3001",
            "209-260-1600",
            "209-260-6440",
            "818-639-9644",
            "614-863-2522",
            "614-291-4100",
            "614-276-3334",
            "614-274-9338",
            "740-788-8631",
            "740-450-7720",
            "440-392-2274",
            "419-382-5385",
            "216-739-0837",
            "216-289-8462",
            "440-269-1318",
            "440-734-2749",
            "440-363-4288",
            "330-966-1752",
            "419-424-3164"});
            this.cBCall.Location = new System.Drawing.Point(67, 17);
            this.cBCall.Margin = new System.Windows.Forms.Padding(4);
            this.cBCall.Name = "cBCall";
            this.cBCall.Size = new System.Drawing.Size(107, 24);
            this.cBCall.TabIndex = 15;
            this.cBCall.SelectedIndexChanged += new System.EventHandler(this.cBCall_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone #:";
            // 
            // cBStore
            // 
            this.cBStore.AutoCompleteCustomSource.AddRange(new string[] {
            "CA656",
            "OH020",
            "OH127"});
            this.cBStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBStore.FormattingEnabled = true;
            this.cBStore.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
            "009",
            "010",
            "011",
            "012",
            "013",
            "014",
            "015",
            "016",
            "017",
            "018",
            "019",
            "020",
            "022",
            "023",
            "024",
            "025",
            "026",
            "027",
            "028",
            "030",
            "031",
            "032",
            "034",
            "036",
            "037",
            "038",
            "039",
            "040",
            "043",
            "046",
            "047",
            "049",
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "057",
            "059",
            "061",
            "063",
            "064",
            "065",
            "068",
            "069",
            "070",
            "071",
            "072",
            "073",
            "074",
            "075",
            "077",
            "078",
            "083",
            "087",
            "88",
            "91",
            "92",
            "93",
            "096",
            "101",
            "102",
            "103",
            "109",
            "110",
            "111",
            "113",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "127",
            "129",
            "130",
            "132",
            "133",
            "134",
            "135",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "145",
            "147",
            "148",
            "149",
            "152",
            "154",
            "156",
            "157",
            "158",
            "159",
            "160",
            "162",
            "163",
            "165",
            "167",
            "169",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "179",
            "180",
            "181",
            "185",
            "188",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "227",
            "228",
            "229",
            "230",
            "232",
            "233",
            "234",
            "238",
            "239",
            "242",
            "243",
            "246",
            "247",
            "251",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "265",
            "266",
            "267",
            "269",
            "270",
            "273",
            "274",
            "275",
            "276",
            "282",
            "283",
            "284",
            "287",
            "294",
            "305",
            "310",
            "313",
            "321",
            "322",
            "327",
            "328",
            "329",
            "334",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359",
            "360",
            "361",
            "362",
            "363",
            "364",
            "365",
            "367",
            "368",
            "381",
            "383",
            "384",
            "386",
            "391",
            "400",
            "420",
            "476",
            "482",
            "485",
            "489",
            "491",
            "492",
            "496",
            "497",
            "502",
            "504",
            "505",
            "506",
            "510",
            "512",
            "515",
            "516",
            "520",
            "521",
            "522",
            "523",
            "524",
            "527",
            "528",
            "529",
            "531",
            "535",
            "536",
            "538",
            "544",
            "547",
            "548",
            "549",
            "550",
            "551",
            "552",
            "553",
            "554",
            "556",
            "558",
            "559",
            "560",
            "561",
            "562",
            "563",
            "564",
            "565",
            "566",
            "567",
            "568",
            "569",
            "570",
            "573",
            "574",
            "575",
            "576",
            "577",
            "578",
            "579",
            "580",
            "581",
            "582",
            "583",
            "587",
            "588",
            "590",
            "591",
            "592",
            "593",
            "594",
            "595",
            "596",
            "597",
            "598",
            "599",
            "602",
            "603",
            "604",
            "605",
            "607",
            "608",
            "609",
            "610",
            "611",
            "612",
            "613",
            "614",
            "615",
            "616",
            "617",
            "618",
            "619",
            "620",
            "621",
            "623",
            "626",
            "627",
            "629",
            "631",
            "632",
            "633",
            "635",
            "637",
            "638",
            "639",
            "640",
            "643",
            "646",
            "647",
            "648",
            "649",
            "650",
            "651",
            "652",
            "653",
            "654",
            "655",
            "656",
            "657",
            "658",
            "659",
            "660",
            "661",
            "662",
            "663",
            "665",
            "666",
            "667",
            "668",
            "669",
            "670",
            "672",
            "673",
            "674",
            "675",
            "677",
            "678",
            "680",
            "681",
            "682",
            "683",
            "684",
            "686",
            "687",
            "688",
            "690",
            "691",
            "693",
            "694",
            "695",
            "696",
            "697",
            "699",
            "700",
            "752",
            "753",
            "796",
            "797",
            "798",
            "799",
            "821",
            "822",
            "824",
            "825",
            "826",
            "827",
            "828",
            "832",
            "833",
            "834",
            "835",
            "836",
            "837",
            "838",
            "839",
            "841",
            "842",
            "843",
            "844",
            "845",
            "846",
            "848",
            "849",
            "850",
            "851",
            "852",
            "853",
            "854",
            "855",
            "856",
            "857",
            "858",
            "860",
            "861",
            "864",
            "865",
            "868",
            "872",
            "874",
            "875",
            "876",
            "877",
            "878",
            "879",
            "880",
            "881",
            "887",
            "888",
            "892",
            "898",
            "962",
            "963",
            "964",
            "969",
            "970",
            "971",
            "972",
            "979",
            "984",
            "1000",
            "1001",
            "1002",
            "1004",
            "1005",
            "1006",
            "1008",
            "1009",
            "1010",
            "1011",
            "1012",
            "1013",
            "1015",
            "1016",
            "1017",
            "1018",
            "1019",
            "1021",
            "1022",
            "1023",
            "1024",
            "1025",
            "1026",
            "1027",
            "1028",
            "1029",
            "1030",
            "1031",
            "1032",
            "1034",
            "1035",
            "1036",
            "1037",
            "1038",
            "1039",
            "1040",
            "1041",
            "057",
            "063",
            "071",
            "102",
            "103",
            "138",
            "140",
            "152",
            "165",
            "175",
            "176",
            "180",
            "190",
            "191",
            "192",
            "197",
            "198",
            "229",
            "230",
            "232",
            "265",
            "267",
            "269",
            "270",
            "497",
            "618",
            "623",
            "629",
            "632",
            "633",
            "638",
            "640",
            "646",
            "654",
            "661",
            "673",
            "674",
            "688",
            "696",
            "825",
            "001",
            "005",
            "006",
            "014",
            "020",
            "024",
            "061",
            "078",
            "122",
            "123",
            "135",
            "185",
            "199",
            "224",
            "294"});
            this.cBStore.Location = new System.Drawing.Point(67, 49);
            this.cBStore.Margin = new System.Windows.Forms.Padding(4);
            this.cBStore.Name = "cBStore";
            this.cBStore.Size = new System.Drawing.Size(59, 24);
            this.cBStore.TabIndex = 13;
            this.cBStore.SelectedIndexChanged += new System.EventHandler(this.cBStore_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Store:";
            // 
            // btnUnhold
            // 
            this.btnUnhold.Location = new System.Drawing.Point(86, 50);
            this.btnUnhold.Name = "btnUnhold";
            this.btnUnhold.Size = new System.Drawing.Size(75, 23);
            this.btnUnhold.TabIndex = 26;
            this.btnUnhold.Text = "Unhold";
            this.btnUnhold.UseVisualStyleBackColor = true;
            this.btnUnhold.Visible = false;
            this.btnUnhold.Click += new System.EventHandler(this.btnUnhold_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConf);
            this.groupBox2.Controls.Add(this.btnSpeaker);
            this.groupBox2.Controls.Add(this.btnHeadset);
            this.groupBox2.Controls.Add(this.btnVolDn);
            this.groupBox2.Controls.Add(this.btnVolUp);
            this.groupBox2.Controls.Add(this.cbTransfer);
            this.groupBox2.Controls.Add(this.brnTransfer);
            this.groupBox2.Controls.Add(this.btnUnhold);
            this.groupBox2.Controls.Add(this.btnUnmute);
            this.groupBox2.Controls.Add(this.btnLogout);
            this.groupBox2.Controls.Add(this.btnHold);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.btnMute);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 81);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnConf
            // 
            this.btnConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnConf.Location = new System.Drawing.Point(331, 18);
            this.btnConf.Margin = new System.Windows.Forms.Padding(4);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(58, 28);
            this.btnConf.TabIndex = 34;
            this.btnConf.Text = "Conf.";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.BackgroundImage = global::CCFICall.Properties.Resources.speaker1600;
            this.btnSpeaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSpeaker.Image = global::CCFICall.Properties.Resources.headset1600;
            this.btnSpeaker.Location = new System.Drawing.Point(222, 47);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(38, 32);
            this.btnSpeaker.TabIndex = 33;
            this.btnSpeaker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSpeaker.UseVisualStyleBackColor = true;
            this.btnSpeaker.Click += new System.EventHandler(this.btnSpeaker_Click);
            // 
            // btnHeadset
            // 
            this.btnHeadset.BackgroundImage = global::CCFICall.Properties.Resources.headset1600;
            this.btnHeadset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeadset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHeadset.Image = global::CCFICall.Properties.Resources.headset1600;
            this.btnHeadset.Location = new System.Drawing.Point(168, 47);
            this.btnHeadset.Name = "btnHeadset";
            this.btnHeadset.Size = new System.Drawing.Size(38, 32);
            this.btnHeadset.TabIndex = 32;
            this.btnHeadset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHeadset.UseVisualStyleBackColor = true;
            this.btnHeadset.Click += new System.EventHandler(this.btnHeadset_Click);
            // 
            // btnVolDn
            // 
            this.btnVolDn.Location = new System.Drawing.Point(266, 52);
            this.btnVolDn.Name = "btnVolDn";
            this.btnVolDn.Size = new System.Drawing.Size(57, 26);
            this.btnVolDn.TabIndex = 31;
            this.btnVolDn.Text = "Vol -";
            this.btnVolDn.UseVisualStyleBackColor = true;
            this.btnVolDn.Click += new System.EventHandler(this.btnVolDn_Click);
            // 
            // btnVolUp
            // 
            this.btnVolUp.Location = new System.Drawing.Point(332, 53);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(57, 26);
            this.btnVolUp.TabIndex = 30;
            this.btnVolUp.Text = "Vol +";
            this.btnVolUp.UseVisualStyleBackColor = true;
            this.btnVolUp.Click += new System.EventHandler(this.btnVolUp_Click);
            // 
            // cbTransfer
            // 
            this.cbTransfer.AutoCompleteCustomSource.AddRange(new string[] {
            "5025551234",
            "4191236541",
            "6143219876"});
            this.cbTransfer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTransfer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbTransfer.FormattingEnabled = true;
            this.cbTransfer.Items.AddRange(new object[] {
            "4200",
            "4202",
            "4204"});
            this.cbTransfer.Location = new System.Drawing.Point(168, 21);
            this.cbTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.cbTransfer.Name = "cbTransfer";
            this.cbTransfer.Size = new System.Drawing.Size(92, 21);
            this.cbTransfer.TabIndex = 29;
            // 
            // brnTransfer
            // 
            this.brnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.brnTransfer.Location = new System.Drawing.Point(268, 18);
            this.brnTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.brnTransfer.Name = "brnTransfer";
            this.brnTransfer.Size = new System.Drawing.Size(58, 28);
            this.brnTransfer.TabIndex = 27;
            this.brnTransfer.Text = "Transfer";
            this.brnTransfer.UseVisualStyleBackColor = true;
            this.brnTransfer.Click += new System.EventHandler(this.brnTransfer_Click);
            // 
            // btnUnmute
            // 
            this.btnUnmute.Location = new System.Drawing.Point(86, 21);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.Size = new System.Drawing.Size(75, 23);
            this.btnUnmute.TabIndex = 20;
            this.btnUnmute.Text = "Unmute";
            this.btnUnmute.UseVisualStyleBackColor = true;
            this.btnUnmute.Visible = false;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnLogout.Location = new System.Drawing.Point(6, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnCall;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtTestAction);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "CCFI Remote Caller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsLbl;
        private System.Windows.Forms.Timer m_timer;
        private System.Windows.Forms.Button btnHangup;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTestAction;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem phoneSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBStore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUnhold;
        private System.Windows.Forms.Button btnUnmute;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.ComboBox cbTransfer;
        private System.Windows.Forms.Button brnTransfer;
        private System.Windows.Forms.Button btnVolDn;
        private System.Windows.Forms.Button btnVolUp;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.Button btnHeadset;
        private System.Windows.Forms.Button btnConf;
    }
}

