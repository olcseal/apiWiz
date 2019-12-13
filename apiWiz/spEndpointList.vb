Imports Microsoft.VisualBasic

Public Class Links
    Public Property alert As String
    Public Property application As String
    Public Property bgp_trap As String
    Public Property configuration As String
    Public Property device As String
    Public Property fingerprint As String
    Public Property global_afsm_settings As String
    Public Property global_detection_settings As String
    Public Property insight As String
    Public Property learning_mitigation As String
    Public Property managed_object As String
    Public Property mitigation As String
    Public Property mitigation_template As String
    Public Property notification_group As String
    Public Property router As String
    Public Property self As String
    Public Property shared_host_detection_setting_request As String
    Public Property shared_host_detection_settings As String
    Public Property smart_alert_setting As String
    Public Property tms_filter_list As String
    Public Property tms_filter_list_request As String
    Public Property tms_group As String
    Public Property tms_port As String
    Public Property user_defined_misuse_type As String
End Class

Public Class Meta
    Public Property api As String
    Public Property api_version As String
    Public Property sp_build_id As String
    Public Property sp_version As String
End Class

Public Class spEndpointList
    Public Property links As Links
    Public Property meta As Meta
End Class

