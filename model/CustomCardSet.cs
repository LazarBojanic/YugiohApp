
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CustomCardSet {
    
    private rootRow[] rowField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("row")]
    public rootRow[] row {
        get {
            return this.rowField;
        }
        set {
            this.rowField = value;
        }
    }
    public CustomCardSet() {
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class rootRow {
    
    private string set_nameField;
    
    private string set_codeField;
    
    private ushort num_of_cardsField;
    
    private System.DateTime tcg_dateField;
    
    private bool tcg_dateFieldSpecified;
    
    /// <remarks/>
    public string set_name {
        get {
            return this.set_nameField;
        }
        set {
            this.set_nameField = value;
        }
    }
    
    /// <remarks/>
    public string set_code {
        get {
            return this.set_codeField;
        }
        set {
            this.set_codeField = value;
        }
    }
    
    /// <remarks/>
    public ushort num_of_cards {
        get {
            return this.num_of_cardsField;
        }
        set {
            this.num_of_cardsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime tcg_date {
        get {
            return this.tcg_dateField;
        }
        set {
            this.tcg_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tcg_dateSpecified {
        get {
            return this.tcg_dateFieldSpecified;
        }
        set {
            this.tcg_dateFieldSpecified = value;
        }
    }
}

