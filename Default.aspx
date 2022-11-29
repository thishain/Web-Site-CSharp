<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto_Diogenes.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-8">
            <div class="flexslider" style="margin-top: 50px;">
                <ul class="slides">
                    <li>
                        <img src="images/mog1.png" />
                        <a href="https://www.wowhead.com/pt/transmog-set=2897/bronzebeard-dwarf-heritage-armor" target="_blank" title="Clique para visualizar no WowHead!">
                            <p class="flex-caption">Bronzebeard (Dwarf) Heritage Armor</p>
                        </a>
                    </li>
                    <li>
                        <img src="images/mog2.png" />
                        <a href="https://www.wowhead.com/pt/transmog-set=2782/rendorei-void-elf-heritage-armor" target="_blank" title="Clique para visualizar no WowHead!">
                            <p class="flex-caption">Ren'dorei (Void Elf) Heritage Armor</p>
                        </a>
                    </li>
                    <li>
                        <img src="images/mog3.png" />
                        <a href="https://www.wowhead.com/pt/transmog-set=669/malefic-raiment" target="_blank" title="Clique para visualizar no WowHead!">
                            <p class="flex-caption">Malefic Raiment</p>
                        </a>
                    </li>
                    <li>
                        <img src="images/mog4.png" />
                        <a href="https://www.wowhead.com/pt/transmog-set=330/glorious-plate" target="_blank" title="Clique para visualizar no WowHead!">
                            <p class="flex-caption">Glorious Plate</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>

    <ul class="separator"></ul>
    <div class="links-page content-wrap">
        <div class="row">
            <div class="col-2">
                <h3><a href="https://www.wowhead.com/items/armor/plate" title="Todas as armaduras!" target="_blank">PLATE</a></h3>
                <a href="PlatesPage.aspx"><img src="images/plateprin.png" /></a>              
            </div>
            <div class="col-1">
                <hr width="1" size="150" />
            </div>

            <div class="col-2">
                <h3><a href="https://www.wowhead.com/items/armor/leather" title="Todas as armaduras!" target="_blank">LEATHER</a></h3>
                <a href="LeatherPage.aspx" > <img src="images/leatherprin.png" /></a>      
            </div>
            <div class="col-1">
                <hr width="1" size="150" />
            </div>
            <div class="col-2">
                <h3><a href="https://www.wowhead.com/items/armor/cloth" title="Todas as armaduras!" target="_blank">CLOTH</a></h3>
                <a href="ClothPage.aspx"><img src="images/clothprin.png" /></a>          
            </div>
                <div class="col-1">
                <hr width="1" size="150" />
            </div>
            <div class="col-2">
                <h3><a href="https://www.wowhead.com/items/armor/mail" title="Todas as armaduras!" target="_blank">MAIL</a></h3>
                <a href="MailPage.aspx"><img src="images/Mail.png" /></a>    
            </div>
        </div>  
    </div>       
    <ul class="separator"></ul>

    xddd



    <script src="flexslide/jquery-1.12.4.min.js"></script>
    <script src="flexslide/jquery.flexslider-min.js"></script>
    <script>
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide"
            });
        });
    </script>

</asp:Content>
