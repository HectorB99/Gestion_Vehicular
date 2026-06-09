<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_consulta_vehiculo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbl_num_serie = New Label()
        lbl_tipo_combustible = New Label()
        lbl_llantas = New Label()
        lbl_tipo_motor = New Label()
        lbl_placa = New Label()
        lbl_color = New Label()
        lbl_modelo = New Label()
        lbl_linea = New Label()
        lbl_marca = New Label()
        lbl_clave_interna = New Label()
        Label37 = New Label()
        Label36 = New Label()
        Label35 = New Label()
        Label34 = New Label()
        Label33 = New Label()
        Label32 = New Label()
        Label31 = New Label()
        Label30 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        tb_folio_gasolina = New TextBox()
        Label27 = New Label()
        tb_monto_casetas = New TextBox()
        Label26 = New Label()
        tb_monto_permiso = New TextBox()
        Label25 = New Label()
        tb_costo_total = New TextBox()
        tb_costo_gasolina = New TextBox()
        tb_gasolina_lts = New TextBox()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        btn_reporte = New Button()
        dtp_ultima_bateria = New DateTimePicker()
        Label16 = New Label()
        btn_guardar = New Button()
        txt_rendimiento = New TextBox()
        Label14 = New Label()
        txt_gas_semanal = New TextBox()
        Label13 = New Label()
        txt_kilometrajen = New TextBox()
        Label12 = New Label()
        txt_kilometrajea = New TextBox()
        Label11 = New Label()
        dtp_vigencia_licencia = New DateTimePicker()
        Label8 = New Label()
        dtp_vigencia_poliza = New DateTimePicker()
        Label10 = New Label()
        Label1 = New Label()
        cb_vehiculos = New ComboBox()
        btn_consultar = New Button()
        btn_volver = New Button()
        Label2 = New Label()
        dtp_llantas = New DateTimePicker()
        Label3 = New Label()
        dtp_prox_llantas = New DateTimePicker()
        Label4 = New Label()
        dtp_aceite = New DateTimePicker()
        Label5 = New Label()
        dtp_prox_aceite = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        txt_poliza = New TextBox()
        Label15 = New Label()
        txt_comentarios = New TextBox()
        Label17 = New Label()
        dtp_ultimo_taller = New DateTimePicker()
        Label18 = New Label()
        txt_nombre_chofer = New TextBox()
        Label19 = New Label()
        dtp_vigencia_tarjeta = New DateTimePicker()
        Label20 = New Label()
        Label21 = New Label()
        tp_horario_entrada = New DateTimePicker()
        tp_horario_salida = New DateTimePicker()
        cbx_limpieza = New CheckBox()
        Label38 = New Label()
        dtm_fecha_captura = New DateTimePicker()
        tb_km_ultimo_servicio = New TextBox()
        tb_km_prox_servicio = New TextBox()
        btn_fotos = New Button()
        SuspendLayout()
        ' 
        ' lbl_num_serie
        ' 
        lbl_num_serie.AutoSize = True
        lbl_num_serie.Location = New Point(1006, 533)
        lbl_num_serie.Name = "lbl_num_serie"
        lbl_num_serie.Size = New Size(82, 15)
        lbl_num_serie.TabIndex = 207
        lbl_num_serie.Text = "_______________"
        ' 
        ' lbl_tipo_combustible
        ' 
        lbl_tipo_combustible.AutoSize = True
        lbl_tipo_combustible.Location = New Point(1006, 491)
        lbl_tipo_combustible.Name = "lbl_tipo_combustible"
        lbl_tipo_combustible.Size = New Size(82, 15)
        lbl_tipo_combustible.TabIndex = 206
        lbl_tipo_combustible.Text = "_______________"
        ' 
        ' lbl_llantas
        ' 
        lbl_llantas.AutoSize = True
        lbl_llantas.Location = New Point(1006, 448)
        lbl_llantas.Name = "lbl_llantas"
        lbl_llantas.Size = New Size(82, 15)
        lbl_llantas.TabIndex = 205
        lbl_llantas.Text = "_______________"
        ' 
        ' lbl_tipo_motor
        ' 
        lbl_tipo_motor.AutoSize = True
        lbl_tipo_motor.Location = New Point(1006, 403)
        lbl_tipo_motor.Name = "lbl_tipo_motor"
        lbl_tipo_motor.Size = New Size(82, 15)
        lbl_tipo_motor.TabIndex = 204
        lbl_tipo_motor.Text = "_______________"
        ' 
        ' lbl_placa
        ' 
        lbl_placa.AutoSize = True
        lbl_placa.Location = New Point(1006, 361)
        lbl_placa.Name = "lbl_placa"
        lbl_placa.Size = New Size(82, 15)
        lbl_placa.TabIndex = 203
        lbl_placa.Text = "_______________"
        ' 
        ' lbl_color
        ' 
        lbl_color.AutoSize = True
        lbl_color.Location = New Point(1006, 318)
        lbl_color.Name = "lbl_color"
        lbl_color.Size = New Size(82, 15)
        lbl_color.TabIndex = 202
        lbl_color.Text = "_______________"
        ' 
        ' lbl_modelo
        ' 
        lbl_modelo.AutoSize = True
        lbl_modelo.Location = New Point(1006, 276)
        lbl_modelo.Name = "lbl_modelo"
        lbl_modelo.Size = New Size(82, 15)
        lbl_modelo.TabIndex = 201
        lbl_modelo.Text = "_______________"
        ' 
        ' lbl_linea
        ' 
        lbl_linea.AutoSize = True
        lbl_linea.Location = New Point(1006, 238)
        lbl_linea.Name = "lbl_linea"
        lbl_linea.Size = New Size(82, 15)
        lbl_linea.TabIndex = 200
        lbl_linea.Text = "_______________"
        ' 
        ' lbl_marca
        ' 
        lbl_marca.AutoSize = True
        lbl_marca.Location = New Point(1006, 194)
        lbl_marca.Name = "lbl_marca"
        lbl_marca.Size = New Size(82, 15)
        lbl_marca.TabIndex = 199
        lbl_marca.Text = "_______________"
        ' 
        ' lbl_clave_interna
        ' 
        lbl_clave_interna.AutoSize = True
        lbl_clave_interna.Location = New Point(1006, 152)
        lbl_clave_interna.Name = "lbl_clave_interna"
        lbl_clave_interna.Size = New Size(82, 15)
        lbl_clave_interna.TabIndex = 198
        lbl_clave_interna.Text = "_______________"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(889, 533)
        Label37.Name = "Label37"
        Label37.Size = New Size(95, 15)
        Label37.TabIndex = 197
        Label37.Text = "Numero de Serie"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(867, 491)
        Label36.Name = "Label36"
        Label36.Size = New Size(117, 15)
        Label36.TabIndex = 196
        Label36.Text = "Tipo de Combustible"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(940, 448)
        Label35.Name = "Label35"
        Label35.Size = New Size(44, 15)
        Label35.TabIndex = 195
        Label35.Text = "Llantas"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(902, 403)
        Label34.Name = "Label34"
        Label34.Size = New Size(82, 15)
        Label34.TabIndex = 194
        Label34.Text = "Tipo de Motor"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(949, 361)
        Label33.Name = "Label33"
        Label33.Size = New Size(35, 15)
        Label33.TabIndex = 193
        Label33.Text = "Placa"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(948, 318)
        Label32.Name = "Label32"
        Label32.Size = New Size(36, 15)
        Label32.TabIndex = 192
        Label32.Text = "Color"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(936, 276)
        Label31.Name = "Label31"
        Label31.Size = New Size(48, 15)
        Label31.TabIndex = 191
        Label31.Text = "Modelo"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(949, 238)
        Label30.Name = "Label30"
        Label30.Size = New Size(35, 15)
        Label30.TabIndex = 190
        Label30.Text = "Línea"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(944, 194)
        Label29.Name = "Label29"
        Label29.Size = New Size(40, 15)
        Label29.TabIndex = 189
        Label29.Text = "Marca"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(908, 152)
        Label28.Name = "Label28"
        Label28.Size = New Size(76, 15)
        Label28.TabIndex = 188
        Label28.Text = "Clave Interna"
        ' 
        ' tb_folio_gasolina
        ' 
        tb_folio_gasolina.Location = New Point(732, 584)
        tb_folio_gasolina.Name = "tb_folio_gasolina"
        tb_folio_gasolina.Size = New Size(106, 23)
        tb_folio_gasolina.TabIndex = 187
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(613, 587)
        Label27.Name = "Label27"
        Label27.Size = New Size(86, 15)
        Label27.TabIndex = 186
        Label27.Text = "Folio del Ticket"
        ' 
        ' tb_monto_casetas
        ' 
        tb_monto_casetas.Location = New Point(732, 690)
        tb_monto_casetas.Name = "tb_monto_casetas"
        tb_monto_casetas.Size = New Size(106, 23)
        tb_monto_casetas.TabIndex = 185
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(597, 693)
        Label26.Name = "Label26"
        Label26.Size = New Size(102, 15)
        Label26.TabIndex = 184
        Label26.Text = "Monto de Casetas"
        ' 
        ' tb_monto_permiso
        ' 
        tb_monto_permiso.Location = New Point(732, 652)
        tb_monto_permiso.Name = "tb_monto_permiso"
        tb_monto_permiso.Size = New Size(106, 23)
        tb_monto_permiso.TabIndex = 183
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(594, 660)
        Label25.Name = "Label25"
        Label25.Size = New Size(105, 15)
        Label25.TabIndex = 182
        Label25.Text = "Monto de Permiso"
        ' 
        ' tb_costo_total
        ' 
        tb_costo_total.Location = New Point(732, 545)
        tb_costo_total.Name = "tb_costo_total"
        tb_costo_total.Size = New Size(106, 23)
        tb_costo_total.TabIndex = 181
        ' 
        ' tb_costo_gasolina
        ' 
        tb_costo_gasolina.Location = New Point(732, 507)
        tb_costo_gasolina.Name = "tb_costo_gasolina"
        tb_costo_gasolina.Size = New Size(106, 23)
        tb_costo_gasolina.TabIndex = 180
        ' 
        ' tb_gasolina_lts
        ' 
        tb_gasolina_lts.Location = New Point(732, 468)
        tb_gasolina_lts.Name = "tb_gasolina_lts"
        tb_gasolina_lts.Size = New Size(106, 23)
        tb_gasolina_lts.TabIndex = 179
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(553, 510)
        Label24.Name = "Label24"
        Label24.Size = New Size(146, 15)
        Label24.TabIndex = 178
        Label24.Text = "Costo de gasolina por litro"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(634, 548)
        Label23.Name = "Label23"
        Label23.Size = New Size(65, 15)
        Label23.TabIndex = 177
        Label23.Text = "Costo total"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(600, 471)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 176
        Label22.Text = "Litros de gasolina"
        ' 
        ' btn_reporte
        ' 
        btn_reporte.Font = New Font("Arial Narrow", 18F)
        btn_reporte.Location = New Point(789, 91)
        btn_reporte.Name = "btn_reporte"
        btn_reporte.Size = New Size(159, 42)
        btn_reporte.TabIndex = 175
        btn_reporte.Text = "Reportes"
        btn_reporte.UseVisualStyleBackColor = True
        ' 
        ' dtp_ultima_bateria
        ' 
        dtp_ultima_bateria.Location = New Point(732, 234)
        dtp_ultima_bateria.Name = "dtp_ultima_bateria"
        dtp_ultima_bateria.Size = New Size(106, 23)
        dtp_ultima_bateria.TabIndex = 174
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(506, 240)
        Label16.Name = "Label16"
        Label16.Size = New Size(193, 15)
        Label16.TabIndex = 173
        Label16.Text = "Fecha de Ultimo Cambio de Batería"
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Arial Narrow", 18F)
        btn_guardar.Location = New Point(590, 91)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(193, 42)
        btn_guardar.TabIndex = 172
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' txt_rendimiento
        ' 
        txt_rendimiento.Location = New Point(732, 395)
        txt_rendimiento.Name = "txt_rendimiento"
        txt_rendimiento.Size = New Size(106, 23)
        txt_rendimiento.TabIndex = 171
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(580, 398)
        Label14.Name = "Label14"
        Label14.Size = New Size(119, 15)
        Label14.TabIndex = 170
        Label14.Text = "Rendimiento (km/ltr)"
        ' 
        ' txt_gas_semanal
        ' 
        txt_gas_semanal.Location = New Point(732, 352)
        txt_gas_semanal.Name = "txt_gas_semanal"
        txt_gas_semanal.Size = New Size(106, 23)
        txt_gas_semanal.TabIndex = 169
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(528, 360)
        Label13.Name = "Label13"
        Label13.Size = New Size(171, 15)
        Label13.TabIndex = 168
        Label13.Text = "Consumo de Gasolina Semanal"
        ' 
        ' txt_kilometrajen
        ' 
        txt_kilometrajen.Location = New Point(732, 315)
        txt_kilometrajen.Name = "txt_kilometrajen"
        txt_kilometrajen.Size = New Size(106, 23)
        txt_kilometrajen.TabIndex = 167
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(594, 318)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 15)
        Label12.TabIndex = 166
        Label12.Text = "Kilometraje Nuevo"
        ' 
        ' txt_kilometrajea
        ' 
        txt_kilometrajea.Location = New Point(732, 275)
        txt_kilometrajea.Name = "txt_kilometrajea"
        txt_kilometrajea.Size = New Size(106, 23)
        txt_kilometrajea.TabIndex = 165
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(586, 280)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 15)
        Label11.TabIndex = 164
        Label11.Text = "Kilometraje Anterior"
        ' 
        ' dtp_vigencia_licencia
        ' 
        dtp_vigencia_licencia.Location = New Point(732, 192)
        dtp_vigencia_licencia.Name = "dtp_vigencia_licencia"
        dtp_vigencia_licencia.Size = New Size(106, 23)
        dtp_vigencia_licencia.TabIndex = 163
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(506, 198)
        Label8.Name = "Label8"
        Label8.Size = New Size(193, 15)
        Label8.TabIndex = 162
        Label8.Text = "Vigencia de Licencia del Conductor"
        ' 
        ' dtp_vigencia_poliza
        ' 
        dtp_vigencia_poliza.Location = New Point(732, 150)
        dtp_vigencia_poliza.Name = "dtp_vigencia_poliza"
        dtp_vigencia_poliza.Size = New Size(106, 23)
        dtp_vigencia_poliza.TabIndex = 161
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(597, 156)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 15)
        Label10.TabIndex = 160
        Label10.Text = "Vigencia de Poliza"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 25)
        Label1.TabIndex = 129
        Label1.Text = "Seleccione el vehiculo"
        ' 
        ' cb_vehiculos
        ' 
        cb_vehiculos.FormattingEnabled = True
        cb_vehiculos.Location = New Point(227, 33)
        cb_vehiculos.Name = "cb_vehiculos"
        cb_vehiculos.Size = New Size(231, 23)
        cb_vehiculos.TabIndex = 130
        ' 
        ' btn_consultar
        ' 
        btn_consultar.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_consultar.Location = New Point(200, 91)
        btn_consultar.Name = "btn_consultar"
        btn_consultar.Size = New Size(189, 42)
        btn_consultar.TabIndex = 131
        btn_consultar.Text = "Consultar"
        btn_consultar.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_volver.Location = New Point(32, 91)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(161, 42)
        btn_volver.TabIndex = 132
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 15)
        Label2.TabIndex = 133
        Label2.Text = "Fecha del Ultimo Cambio de Llantas"
        ' 
        ' dtp_llantas
        ' 
        dtp_llantas.CustomFormat = " "
        dtp_llantas.Location = New Point(257, 150)
        dtp_llantas.Name = "dtp_llantas"
        dtp_llantas.Size = New Size(106, 23)
        dtp_llantas.TabIndex = 134
        dtp_llantas.Value = New Date(2026, 5, 5, 11, 32, 44, 0)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 15)
        Label3.TabIndex = 135
        Label3.Text = "Fecha del Proximo Cambio de Llantas"
        ' 
        ' dtp_prox_llantas
        ' 
        dtp_prox_llantas.Location = New Point(257, 188)
        dtp_prox_llantas.Name = "dtp_prox_llantas"
        dtp_prox_llantas.Size = New Size(106, 23)
        dtp_prox_llantas.TabIndex = 136
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 236)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 15)
        Label4.TabIndex = 137
        Label4.Text = "Fecha del Ultimo Cambio de Aceite"
        ' 
        ' dtp_aceite
        ' 
        dtp_aceite.Location = New Point(257, 230)
        dtp_aceite.Name = "dtp_aceite"
        dtp_aceite.Size = New Size(106, 23)
        dtp_aceite.TabIndex = 138
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(202, 15)
        Label5.TabIndex = 139
        Label5.Text = "Fecha del Proximo Cambio de Aceite"
        ' 
        ' dtp_prox_aceite
        ' 
        dtp_prox_aceite.Location = New Point(257, 270)
        dtp_prox_aceite.Name = "dtp_prox_aceite"
        dtp_prox_aceite.Size = New Size(106, 23)
        dtp_prox_aceite.TabIndex = 140
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(65, 316)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 15)
        Label7.TabIndex = 141
        Label7.Text = "Kilometraje del Ultimo Servicio"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(56, 356)
        Label6.Name = "Label6"
        Label6.Size = New Size(178, 15)
        Label6.TabIndex = 143
        Label6.Text = "Kilometraje del Proximo Servicio"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(140, 393)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 15)
        Label9.TabIndex = 145
        Label9.Text = "Poliza de Seguro"
        ' 
        ' txt_poliza
        ' 
        txt_poliza.Location = New Point(257, 393)
        txt_poliza.Name = "txt_poliza"
        txt_poliza.Size = New Size(106, 23)
        txt_poliza.TabIndex = 146
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(43, 736)
        Label15.Name = "Label15"
        Label15.Size = New Size(75, 15)
        Label15.TabIndex = 147
        Label15.Text = "Comentarios"
        ' 
        ' txt_comentarios
        ' 
        txt_comentarios.Location = New Point(157, 733)
        txt_comentarios.Multiline = True
        txt_comentarios.Name = "txt_comentarios"
        txt_comentarios.Size = New Size(402, 50)
        txt_comentarios.TabIndex = 148
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(24, 696)
        Label17.Name = "Label17"
        Label17.Size = New Size(113, 15)
        Label17.TabIndex = 149
        Label17.Text = "Ultima visita al taller"
        ' 
        ' dtp_ultimo_taller
        ' 
        dtp_ultimo_taller.Location = New Point(157, 690)
        dtp_ultimo_taller.Name = "dtp_ultimo_taller"
        dtp_ultimo_taller.Size = New Size(106, 23)
        dtp_ultimo_taller.TabIndex = 150
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(125, 476)
        Label18.Name = "Label18"
        Label18.Size = New Size(109, 15)
        Label18.TabIndex = 151
        Label18.Text = "Nombre del Chofer"
        ' 
        ' txt_nombre_chofer
        ' 
        txt_nombre_chofer.Location = New Point(257, 468)
        txt_nombre_chofer.Name = "txt_nombre_chofer"
        txt_nombre_chofer.Size = New Size(106, 23)
        txt_nombre_chofer.TabIndex = 152
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(50, 510)
        Label19.Name = "Label19"
        Label19.Size = New Size(184, 15)
        Label19.TabIndex = 153
        Label19.Text = "Vigencia de Tarjeta de Circulación"
        ' 
        ' dtp_vigencia_tarjeta
        ' 
        dtp_vigencia_tarjeta.Location = New Point(257, 504)
        dtp_vigencia_tarjeta.Name = "dtp_vigencia_tarjeta"
        dtp_vigencia_tarjeta.Size = New Size(106, 23)
        dtp_vigencia_tarjeta.TabIndex = 154
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(142, 548)
        Label20.Name = "Label20"
        Label20.Size = New Size(92, 15)
        Label20.TabIndex = 155
        Label20.Text = "Hora de Entrada"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(151, 585)
        Label21.Name = "Label21"
        Label21.Size = New Size(83, 15)
        Label21.TabIndex = 156
        Label21.Text = "Hora de Salida"
        ' 
        ' tp_horario_entrada
        ' 
        tp_horario_entrada.CustomFormat = "HH:mm"
        tp_horario_entrada.Format = DateTimePickerFormat.Custom
        tp_horario_entrada.Location = New Point(257, 542)
        tp_horario_entrada.Name = "tp_horario_entrada"
        tp_horario_entrada.ShowUpDown = True
        tp_horario_entrada.Size = New Size(106, 23)
        tp_horario_entrada.TabIndex = 157
        ' 
        ' tp_horario_salida
        ' 
        tp_horario_salida.CustomFormat = "HH:mm"
        tp_horario_salida.Format = DateTimePickerFormat.Custom
        tp_horario_salida.Location = New Point(257, 581)
        tp_horario_salida.Name = "tp_horario_salida"
        tp_horario_salida.ShowUpDown = True
        tp_horario_salida.Size = New Size(106, 23)
        tp_horario_salida.TabIndex = 158
        ' 
        ' cbx_limpieza
        ' 
        cbx_limpieza.AutoSize = True
        cbx_limpieza.Location = New Point(32, 659)
        cbx_limpieza.Name = "cbx_limpieza"
        cbx_limpieza.Size = New Size(73, 19)
        cbx_limpieza.TabIndex = 159
        cbx_limpieza.Text = "Limpieza"
        cbx_limpieza.UseVisualStyleBackColor = True
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(497, 31)
        Label38.Name = "Label38"
        Label38.Size = New Size(62, 25)
        Label38.TabIndex = 208
        Label38.Text = "Fecha"
        ' 
        ' dtm_fecha_captura
        ' 
        dtm_fecha_captura.CustomFormat = " "
        dtm_fecha_captura.Location = New Point(570, 33)
        dtm_fecha_captura.Name = "dtm_fecha_captura"
        dtm_fecha_captura.Size = New Size(129, 23)
        dtm_fecha_captura.TabIndex = 209
        dtm_fecha_captura.Value = New Date(2026, 5, 16, 0, 0, 0, 0)
        ' 
        ' tb_km_ultimo_servicio
        ' 
        tb_km_ultimo_servicio.Location = New Point(257, 315)
        tb_km_ultimo_servicio.Name = "tb_km_ultimo_servicio"
        tb_km_ultimo_servicio.Size = New Size(106, 23)
        tb_km_ultimo_servicio.TabIndex = 210
        ' 
        ' tb_km_prox_servicio
        ' 
        tb_km_prox_servicio.Location = New Point(257, 353)
        tb_km_prox_servicio.Name = "tb_km_prox_servicio"
        tb_km_prox_servicio.Size = New Size(106, 23)
        tb_km_prox_servicio.TabIndex = 211
        ' 
        ' btn_fotos
        ' 
        btn_fotos.Font = New Font("Arial Narrow", 18F)
        btn_fotos.Location = New Point(395, 91)
        btn_fotos.Name = "btn_fotos"
        btn_fotos.Size = New Size(189, 42)
        btn_fotos.TabIndex = 212
        btn_fotos.Text = "Visualizar Fotos"
        btn_fotos.UseVisualStyleBackColor = True
        ' 
        ' Form_consulta_vehiculo
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1109, 815)
        Controls.Add(btn_fotos)
        Controls.Add(tb_km_prox_servicio)
        Controls.Add(tb_km_ultimo_servicio)
        Controls.Add(dtm_fecha_captura)
        Controls.Add(Label38)
        Controls.Add(lbl_num_serie)
        Controls.Add(lbl_tipo_combustible)
        Controls.Add(lbl_llantas)
        Controls.Add(lbl_tipo_motor)
        Controls.Add(lbl_placa)
        Controls.Add(lbl_color)
        Controls.Add(lbl_modelo)
        Controls.Add(lbl_linea)
        Controls.Add(lbl_marca)
        Controls.Add(lbl_clave_interna)
        Controls.Add(Label37)
        Controls.Add(Label36)
        Controls.Add(Label35)
        Controls.Add(Label34)
        Controls.Add(Label33)
        Controls.Add(Label32)
        Controls.Add(Label31)
        Controls.Add(Label30)
        Controls.Add(Label29)
        Controls.Add(Label28)
        Controls.Add(tb_folio_gasolina)
        Controls.Add(Label27)
        Controls.Add(tb_monto_casetas)
        Controls.Add(Label26)
        Controls.Add(tb_monto_permiso)
        Controls.Add(Label25)
        Controls.Add(tb_costo_total)
        Controls.Add(tb_costo_gasolina)
        Controls.Add(tb_gasolina_lts)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(btn_reporte)
        Controls.Add(dtp_ultima_bateria)
        Controls.Add(Label16)
        Controls.Add(btn_guardar)
        Controls.Add(txt_rendimiento)
        Controls.Add(Label14)
        Controls.Add(txt_gas_semanal)
        Controls.Add(Label13)
        Controls.Add(txt_kilometrajen)
        Controls.Add(Label12)
        Controls.Add(txt_kilometrajea)
        Controls.Add(Label11)
        Controls.Add(dtp_vigencia_licencia)
        Controls.Add(Label8)
        Controls.Add(dtp_vigencia_poliza)
        Controls.Add(Label10)
        Controls.Add(Label1)
        Controls.Add(cb_vehiculos)
        Controls.Add(btn_consultar)
        Controls.Add(btn_volver)
        Controls.Add(Label2)
        Controls.Add(dtp_llantas)
        Controls.Add(Label3)
        Controls.Add(dtp_prox_llantas)
        Controls.Add(Label4)
        Controls.Add(dtp_aceite)
        Controls.Add(Label5)
        Controls.Add(dtp_prox_aceite)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label9)
        Controls.Add(txt_poliza)
        Controls.Add(Label15)
        Controls.Add(txt_comentarios)
        Controls.Add(Label17)
        Controls.Add(dtp_ultimo_taller)
        Controls.Add(Label18)
        Controls.Add(txt_nombre_chofer)
        Controls.Add(Label19)
        Controls.Add(dtp_vigencia_tarjeta)
        Controls.Add(Label20)
        Controls.Add(Label21)
        Controls.Add(tp_horario_entrada)
        Controls.Add(tp_horario_salida)
        Controls.Add(cbx_limpieza)
        Name = "Form_consulta_vehiculo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta Vehicular"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_num_serie As Label
    Friend WithEvents lbl_tipo_combustible As Label
    Friend WithEvents lbl_llantas As Label
    Friend WithEvents lbl_tipo_motor As Label
    Friend WithEvents lbl_placa As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_modelo As Label
    Friend WithEvents lbl_linea As Label
    Friend WithEvents lbl_marca As Label
    Friend WithEvents lbl_clave_interna As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tb_folio_gasolina As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tb_monto_casetas As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tb_monto_permiso As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents tb_costo_total As TextBox
    Friend WithEvents tb_costo_gasolina As TextBox
    Friend WithEvents tb_gasolina_lts As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btn_reporte As Button
    Friend WithEvents dtp_ultima_bateria As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_rendimiento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_gas_semanal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_kilometrajen As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_kilometrajea As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtp_vigencia_licencia As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtp_vigencia_poliza As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_vehiculos As ComboBox
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_llantas As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_prox_llantas As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_aceite As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_prox_aceite As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_poliza As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_comentarios As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtp_ultimo_taller As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_nombre_chofer As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_vigencia_tarjeta As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tp_horario_entrada As DateTimePicker
    Friend WithEvents tp_horario_salida As DateTimePicker
    Friend WithEvents cbx_limpieza As CheckBox
    Friend WithEvents Label38 As Label
    Friend WithEvents dtm_fecha_captura As DateTimePicker
    Friend WithEvents tb_km_ultimo_servicio As TextBox
    Friend WithEvents tb_km_prox_servicio As TextBox
    Friend WithEvents btn_fotos As Button
End Class
