using TMPro;
using UnityEditor.SceneManagement;
using UnityEditor.SearchService;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI descriptionTextBox;
    private string descriptiontext = "";
    AccessManager accessManager = new AccessManager();

    public void changeTextBox()
    {
        SetText(ValueToKeep.placeToKeep, ValueToKeep.moodToKeep);
        descriptionTextBox.text = descriptiontext;
    }
    public string SetText(string place, uint currentMood)
    {

        // A nested switch statement containing two parameters: place & currentMood
        switch (place)
        {
            //The Elevator is first locked and eventually unlocked
            case "Elevator":
                switch (currentMood)
                {
                    case 1:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Ein Aufzug, der in die Jahre gekommen ist. Erstaunlich, dass er �berhaupt noch f�hrt."; }
                        else { descriptiontext = "Ein Aufzug, der in die Jahre gekommen ist. Die Kn�pfe zu \"Keller\" \"Erdgeschoss\" und \"1. Stock\" leuchten nicht, wenn ich sie dr�cke. Vielleicht ist er kapput?"; }
                        break;
                    case 2:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Die Seile an denen er h�ngt, quietschen und �chzen. Fast so, als wollten sie ihn in fallenlassen."; }
                        else { descriptiontext = "Wer auch immer ihn manipuliert hat, kann mir vielleicht meine Fragen beantworten."; }
                        break;
                    case 3:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Ich glaube diesem Gef�hrt erging es genauso wie mir. Wir beide sind zu voll beladen und werden irgendwann abst�rzen."; }
                        descriptiontext = "Dieses Mistst�ck habe ich immer noch immer nicht zum Laufen gebracht.";
                        break;
                }
                break;
            //Chapter 1
            case "Awakening Room":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Das ist also der Escape Room, in den sie mich bringen wollten.";
                        break;
                    case 2:
                        descriptiontext = "Warum kommt keiner, um mich abzuholen?";
                        break;
                    case 3:
                        descriptiontext = "Vielleicht h�tte ich mich an den Schl�uchen aufh�ngen sollen.";
                        break;
                }
                break;
            case "Basement Corridor":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ich sehe nichts. Es riecht nach abgestandener Luft und meine Schritte verhallen.";
                        break;
                    case 2:
                        descriptiontext = "Schwarz. Endloses, undurchdringliches, nervt�tendes Schwarz.";
                        break;
                    case 3:
                        descriptiontext = "Schwarz. Trostloses, fl�sterndes, totes Schwarz.";
                        break;
                }
                break;
            case "Engine Room":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ein Haufen Generatoren, die heruntergefahren sind, darunter auch ein Elektrokasten.";
                        break;
                    case 2:
                        descriptiontext = "Sie brauchen Strom, aber seit wann braucht ein Escape Room so viel Strom?";
                        break;
                    case 3:
                        descriptiontext = "Damit leiten sie den Strom auf den Stuhl, auf den man nur ein letztes Mal Platz nehmen darf.";
                        break;
                }
                break;
            case "Fuse Box":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Der Elektrokasten.";
                        break;
                    case 2:
                        descriptiontext = "Ich habe genug Kurzschl�sse selbst ausgel�st und lasse besser die Finger davon.";
                        break;
                    case 3:
                        descriptiontext = "Meine H�nde wollen nach diesem greifen und die gleichen Pole zusammenf�hren.";
                        break;
                }
                break;
            case "Lounge":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Der Geruch von Desinfektionsmittel liegt in der Luft - die B�den scheinen frisch gewaschen.";
                        break;
                    case 2:
                        descriptiontext = "Hier hat sie immer dieser Konzerte gegeben, bis sie die Saiten mit einer Zange durchgezwickt hat.";
                        break;
                    case 3:
                        descriptiontext = "Sie spielt wieder diese Melodie, die mich an ein Davor und das Danach erinnert.";
                        break;
                }
                break;
            case "Piano":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ich war nie ein Spieler.";
                        break;
                    case 2:
                        descriptiontext = "b-Moll war immer noch meine Lieblingstonart.";
                        break;
                    case 3:
                        descriptiontext = "Wenn ich etwas konnte, dann wohl, dass ich nichts konnte.";
                        break;
                }
                break;
            case "Chess":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Jemand hat inmitten der Partie aufgeh�rt.";
                        break;
                    case 2:
                        descriptiontext = "Die Partie h�tte in ein paar Z�gen geendet.";
                        break;
                    case 3:
                        descriptiontext = "Ich verstehe, warum jemand in dieser Position nicht weiterspielen wollte.";
                        break;
                }
                break;
            case "Library":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Hier habe ich immer meine Ruhe gefunden.";
                        break;
                    case 2:
                        descriptiontext = "Verstaubtes Wissen, dass uns immer wieder erkl�rt, warum wir nichts wissen.";
                        break;
                    case 3:
                        descriptiontext = "Hier habe ich meine letzte Ruhe gefunden.";
                        break;
                }
                break;
            //Chapter 2
            case "1st Florr Corridor":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ich sehe etwas: Das Stockwerk, vor dem mich die Bettlerin gewarnt hat.";
                        break;
                    case 2:
                        descriptiontext = "Bin ich hier schon mal gewesen? Irgendwo muss doch hier ein Ausgang sein.";
                        break;
                    case 3:
                        descriptiontext = "Hier haben sie uns also untersucht.";
                        break;
                }
                break;
            case "Windowless Room 1":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Eine T�r.";
                        break;
                    case 2:
                        descriptiontext = "Das Messingschild \"1\" ist heruntergefallen.";
                        break;
                    case 3:
                        descriptiontext = "In dem fensterlosen Einzelzimmer gibt es ein Fenster. Hinter dem Fenster viel Luft. Zwischen Luft und Boden viel Zeit zu fallen.";
                        break;
                }
                break;
            case "Windowless Room 2":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Eine T�r.";
                        break;
                    case 2:
                        descriptiontext = "Das Messingschild \"2\" ist noch an seiner urspr�nglichen Position.";
                        break;
                    case 3:
                        descriptiontext = "Die T�r ist einen Spalt offen und dahinter h�re ich r�chelnde Laute.";
                        break;
                }
                break;
            case "Windowless Room 3":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Eine T�r.";
                        break;
                    case 2:
                        descriptiontext = "Das Messingschild \"3\" scheint sich nur noch an einen Nageln zu klammern.";
                        break;
                    case 3:
                        descriptiontext = "Unter dem Spalt sehe ich Licht, dass aus und wieder angeht.";
                        break;
                }
                break;
            case "Windowless Room 4":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Irgendwas hat die T�r zerfetzt. Sie liegt tief in den Angeln.";
                        break;
                    case 2:
                        descriptiontext = "Das Messingschild an der T�r ist nicht existent. Das Holz wurde von innen zerfetzt, was nur bedeuten kann, dass da jemand hinausm�chte.";
                        break;
                    case 3:
                        descriptiontext = "Unter dem Spalt sehe ich Licht, dass aus und wieder angeht.";
                        break;
                }
                break;
            case "Deescalation Room":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Diese T�r hat keine Klinke. Ein leises Murmeln meine ich aus dem Schl�sselloch zu vernehmen.";
                        break;
                    case 2:
                        descriptiontext = "Jemand ruft meinen Namen.";
                        break;
                    case 3:
                        descriptiontext = "Die Stimme sagt, dass ich es machen soll, so wie ich es damals gemacht habe.";
                        break;
                }
                break;
            //The Archive is first locked and eventually unlocked
            case "Archive":
                switch (currentMood)
                {
                    case 1:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Verstaubte Aktenschr�nke."; }
                        else { descriptiontext = "\"Archiv\""; }
                        break;
                    case 2:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Irgendjemand hat die Seiten rausgerissen und auf einen Haufen geworfen. Fast so, als wollte jemand ein Feuer machen."; }
                        else { descriptiontext = "\"Archiv - Dokumentation\""; }
                        break;
                    case 3:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Ich rieche Benzin. Wo ist nur mein Feuerzeug?"; }
                        descriptiontext = "\"Archiv - Dokumentation f�r Psychiatrie\"";
                        break;
                }
                break;
            case "Medical Base":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "*";
                        ;
                        break;
                    case 2:
                        descriptiontext = "**";
                        break;
                    case 3:
                        descriptiontext = "***";
                        break;
                }
                break;
            //Chapter 3
            case "Ground Floor Corridor":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Endlich komme ich dem Ausgang nahe!";
                        ;
                        break;
                    case 2:
                        descriptiontext = "Eingang oder Ausgang, das ist hier Frage.";
                        break;
                    case 3:
                        descriptiontext = "Die haben die Anweisung, mich nicht rauszulassen.";
                        break;
                }
                break;

            case "Reception":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "\"The most realistic Escape-Room: 'Sideeffects guaranteed'\" Hier habe ich bezahlt, um den Spa� meines Lebens zu haben.";
                        ;
                        break;
                    case 2:
                        descriptiontext = "Ich kann mich komischerweise nicht daran erinnern, bezahlt zu haben!";
                        break;
                    case 3:
                        descriptiontext = "An der Rezeption stehen hagere Personen sie cheken gerade aus. Jetzt sind sie weg!";
                        break;
                }
                break;
            //The Office is first locked and eventually unlocked
            case "Office":
                switch (currentMood)
                {
                    case 1:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Ein langweiliger, geordneter Schreibtisch. Dahinter mehrere Bildschirme, auf denen ich mehrere Teilnehmer entdecke."; }
                        else { descriptiontext = "\"Zutritt nur f�r Personal\""; }
                        break;
                    case 2:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Hinter einem bulligen Typen sehe ich eine Wand mit �berwachungsbildschirmen."; }
                        else { descriptiontext = "\"Zutritt nur f�r Personal der psychiatrischen Einrichtung\""; }
                        break;
                    case 3:
                        if (accessManager.hasRepairedElevator) { descriptiontext = "Eine Glatzkopf in einer Uniform, an dessen G�rtel eine Waffe h�ngt."; }
                        descriptiontext = "\"Zutritt nur f�r Mitverschw�rer\"";
                        break;
                }
                break;
            case "Vending Machine":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ein simpler Snackautomat, der regelm��ig nachgef�llt wird. Ich kann einige gew�hnliche Snacks erkennen.";
                        break;
                    case 2:
                        descriptiontext = "Ein mysteri�ser Snackautomat, der schon lange nicht mehr nachgef�llt wurde.";
                        break;
                    case 3:
                        descriptiontext = "Ein interessanter Snackautomat, in dem man abgetrennte K�rperteile kaufen kann. Der Verwesungsgeruch steigt in meine Nase.";
                        break;
                }
                break;
            case "Exit":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Endlich Drau�en!";
                        break;
                    case 2:
                        descriptiontext = "Ich lebe noch!";
                        break;
                    case 3:
                        descriptiontext = "Unm�glich!";
                        break;
                }
                break;
        }
        //returning the eveluated description
        return descriptiontext;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetText(ValueToKeep.placeToKeep, ValueToKeep.moodToKeep);
        changeTextBox();

    }
    // Update is called once per frame
    void Update()
    {
        SetText(ValueToKeep.placeToKeep, ValueToKeep.moodToKeep);
        changeTextBox();
    }

}
