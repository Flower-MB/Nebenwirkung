using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Sanity sanity;
    public int currentMood;
    
    public string SetText(string place, int currentMood)
    {
        string descriptiontext = "";
        // A nested switch statement containing two parameters: place & currentMood
        switch (place)
        {
            //The Elevator is first locked and eventually unlocked
            case "Elevator*":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ein Aufzug, der in die Jahre gekommen ist. Die Knöpfe zu \"Keller\" \"Erdgeschoss\" und \"1. Stock\" leuchten nicht, wenn ich sie drücke. Vielleicht ist er kapput?";
                        break;
                    case 2:
                        descriptiontext = "Wer auch immer ihn manipuliert hat, kann mir vielleicht meine Fragen beantworten.";
                        break;
                    case 3:
                        descriptiontext = "Dieses Miststück habe ich immer noch immer nicht zum Laufen gebracht.";
                        break;
                }
                break;
            case "Elevator":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Ein Aufzug, der in die Jahre gekommen ist. Erstaunlich, dass er überhaupt noch fährt.";
                        break;
                    case 2:
                        descriptiontext = "Die Seile an denen er hängt, quietschen und ächzen. Fast so, als wollten sie ihn in fallenlassen.";
                        break;
                    case 3:
                        descriptiontext = "Ich glaube diesem Gefährt erging es genauso wie mir. Wir beide sind zu voll beladen und werden irgendwann abstürzen.";
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
                        descriptiontext = "Vielleicht hätte ich mich an den Schläuchen aufhängen sollen.";
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
                        descriptiontext = "Schwarz. Endloses, undurchdringliches, nervtötendes Schwarz.";
                        break;
                    case 3:
                        descriptiontext = "Schwarz. Trostloses, flüsterndes, totes Schwarz.";
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
                        descriptiontext = "Ich habe genug Kurzschlüsse selbst ausgelöst und lasse besser die Finger davon.";
                        break;
                    case 3:
                        descriptiontext = "Meine Hände wollen nach diesem greifen und die gleichen Pole zusammenführen.";
                        break;
                }
                break;
            case "Lounge":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Der Geruch von Desinfektionsmittel liegt in der Luft - die Böden scheinen frisch gewaschen.";
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
                        descriptiontext = "Jemand hat inmitten der Partie aufgehört.";
                        break;
                    case 2:
                        descriptiontext = "Die Partie hätte in ein paar Zügen geendet.";
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
                        descriptiontext = "Verstaubtes Wissen, dass uns immer wieder erklärt, warum wir nichts wissen.";
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
                        descriptiontext = "Eine Tür.";
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
                        descriptiontext = "Eine Tür.";
                        break;
                    case 2:
                        descriptiontext = "Das Messingschild \"2\" ist noch an seiner ursprünglichen Position.";
                        break;
                    case 3:
                        descriptiontext = "Die Tür ist einen Spalt offen und dahinter höre ich röchelnde Laute.";
                        break;
                }
                break;
            case "Windowless Room 3":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Eine Tür.";
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
                        descriptiontext = "Irgendwas hat die Tür zerfetzt. Sie liegt tief in den Angeln.";
                        break;
                    case 2:
                        descriptiontext = "Das Messingschild an der Tür ist nicht existent. Das Holz wurde von innen zerfetzt, was nur bedeuten kann, dass da jemand hinausmöchte.";
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
                        descriptiontext = "Diese Tür hat keine Klinke. Ein leises Murmeln meine ich aus dem Schlüsselloch zu vernehmen.";
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
            case "Archive*":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Archiv";
                        ;
                        break;
                    case 2:
                        descriptiontext = "Archiv - Dokumentation";
                        break;
                    case 3:
                        descriptiontext = "Archiv - Dokumentation für Psychiatrie";
                        break;
                }
                break;
            case "Archive":
                switch (currentMood)
                {
                    case 1:
                        descriptiontext = "Verstaubte Aktenschränke.";
                        ;
                        break;
                    case 2:
                        descriptiontext = "Irgendjemand hat die Seiten rausgerissen und auf einen Haufen geworfen. Fast so, als wollte jemand ein Feuer machen.";
                        break;
                    case 3:
                        descriptiontext = "Ich rieche Benzin. Wo ist nur mein Feuerzeug?";
                        break;
                }
                break;
        }
        //returning the eveluated description
        return descriptiontext;
    }
}
