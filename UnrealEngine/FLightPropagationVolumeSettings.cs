using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200268F RID: 9871
	[UnrealObjectPath("/Script/Renderer.LightPropagationVolumeSettings")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FLightPropagationVolumeSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024A2A RID: 150058 RVA: 0x00363CAE File Offset: 0x00361EAE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightPropagationVolumeSettings._ScriptStructPtr != 0) ? FLightPropagationVolumeSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.LightPropagationVolumeSettings", ref FLightPropagationVolumeSettings._ScriptStructPtr);
		}

		// Token: 0x17008D40 RID: 36160
		// (get) Token: 0x06024A2B RID: 150059 RVA: 0x00363CD2 File Offset: 0x00361ED2
		// (set) Token: 0x06024A2C RID: 150060 RVA: 0x00363CEB File Offset: 0x00361EEB
		public unsafe bool bOverride_LPVIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVIntensity : 0));
			}
		}

		// Token: 0x17008D41 RID: 36161
		// (get) Token: 0x06024A2D RID: 150061 RVA: 0x00363D1B File Offset: 0x00361F1B
		// (set) Token: 0x06024A2E RID: 150062 RVA: 0x00363D34 File Offset: 0x00361F34
		public unsafe bool bOverride_LPVDirectionalOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionIntensity : 0));
			}
		}

		// Token: 0x17008D42 RID: 36162
		// (get) Token: 0x06024A2F RID: 150063 RVA: 0x00363D64 File Offset: 0x00361F64
		// (set) Token: 0x06024A30 RID: 150064 RVA: 0x00363D7D File Offset: 0x00361F7D
		public unsafe bool bOverride_LPVDirectionalOcclusionRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionRadius) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionRadius) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionRadius) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionRadius) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionRadius : 0));
			}
		}

		// Token: 0x17008D43 RID: 36163
		// (get) Token: 0x06024A31 RID: 150065 RVA: 0x00363DAD File Offset: 0x00361FAD
		// (set) Token: 0x06024A32 RID: 150066 RVA: 0x00363DC6 File Offset: 0x00361FC6
		public unsafe bool bOverride_LPVDiffuseOcclusionExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionExponent) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionExponent) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionExponent) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionExponent) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionExponent : 0));
			}
		}

		// Token: 0x17008D44 RID: 36164
		// (get) Token: 0x06024A33 RID: 150067 RVA: 0x00363DF6 File Offset: 0x00361FF6
		// (set) Token: 0x06024A34 RID: 150068 RVA: 0x00363E0F File Offset: 0x0036200F
		public unsafe bool bOverride_LPVSpecularOcclusionExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionExponent) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSpecularOcclusionExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionExponent) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionExponent) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSpecularOcclusionExponent) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSpecularOcclusionExponent : 0));
			}
		}

		// Token: 0x17008D45 RID: 36165
		// (get) Token: 0x06024A35 RID: 150069 RVA: 0x00363E3F File Offset: 0x0036203F
		// (set) Token: 0x06024A36 RID: 150070 RVA: 0x00363E58 File Offset: 0x00362058
		public unsafe bool bOverride_LPVDiffuseOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionIntensity : 0));
			}
		}

		// Token: 0x17008D46 RID: 36166
		// (get) Token: 0x06024A37 RID: 150071 RVA: 0x00363E88 File Offset: 0x00362088
		// (set) Token: 0x06024A38 RID: 150072 RVA: 0x00363EA1 File Offset: 0x003620A1
		public unsafe bool bOverride_LPVSpecularOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSpecularOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSpecularOcclusionIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSpecularOcclusionIntensity : 0));
			}
		}

		// Token: 0x17008D47 RID: 36167
		// (get) Token: 0x06024A39 RID: 150073 RVA: 0x00363ED1 File Offset: 0x003620D1
		// (set) Token: 0x06024A3A RID: 150074 RVA: 0x00363EEA File Offset: 0x003620EA
		public unsafe bool bOverride_LPVSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSize) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSize) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSize) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSize) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSize : 0));
			}
		}

		// Token: 0x17008D48 RID: 36168
		// (get) Token: 0x06024A3B RID: 150075 RVA: 0x00363F1A File Offset: 0x0036211A
		// (set) Token: 0x06024A3C RID: 150076 RVA: 0x00363F33 File Offset: 0x00362133
		public unsafe bool bOverride_LPVSecondaryOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSecondaryOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSecondaryOcclusionIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSecondaryOcclusionIntensity : 0));
			}
		}

		// Token: 0x17008D49 RID: 36169
		// (get) Token: 0x06024A3D RID: 150077 RVA: 0x00363F63 File Offset: 0x00362163
		// (set) Token: 0x06024A3E RID: 150078 RVA: 0x00363F7C File Offset: 0x0036217C
		public unsafe bool bOverride_LPVSecondaryBounceIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSecondaryBounceIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSecondaryBounceIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSecondaryBounceIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVSecondaryBounceIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSecondaryBounceIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVSecondaryBounceIntensity : 0));
			}
		}

		// Token: 0x17008D4A RID: 36170
		// (get) Token: 0x06024A3F RID: 150079 RVA: 0x00363FAC File Offset: 0x003621AC
		// (set) Token: 0x06024A40 RID: 150080 RVA: 0x00363FC5 File Offset: 0x003621C5
		public unsafe bool bOverride_LPVGeometryVolumeBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVGeometryVolumeBias) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVGeometryVolumeBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVGeometryVolumeBias) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVGeometryVolumeBias) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVGeometryVolumeBias) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVGeometryVolumeBias : 0));
			}
		}

		// Token: 0x17008D4B RID: 36171
		// (get) Token: 0x06024A41 RID: 150081 RVA: 0x00363FF5 File Offset: 0x003621F5
		// (set) Token: 0x06024A42 RID: 150082 RVA: 0x0036400E File Offset: 0x0036220E
		public unsafe bool bOverride_LPVVplInjectionBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVVplInjectionBias) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVVplInjectionBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVVplInjectionBias) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVVplInjectionBias) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVVplInjectionBias) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVVplInjectionBias : 0));
			}
		}

		// Token: 0x17008D4C RID: 36172
		// (get) Token: 0x06024A43 RID: 150083 RVA: 0x0036403E File Offset: 0x0036223E
		// (set) Token: 0x06024A44 RID: 150084 RVA: 0x00364057 File Offset: 0x00362257
		public unsafe bool bOverride_LPVEmissiveInjectionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVEmissiveInjectionIntensity) & FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVEmissiveInjectionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVEmissiveInjectionIntensity) = ((*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_bOverride_LPVEmissiveInjectionIntensity) & ~FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVEmissiveInjectionIntensity) | (value ? FLightPropagationVolumeSettings.__PropertyMask_bOverride_LPVEmissiveInjectionIntensity : 0));
			}
		}

		// Token: 0x17008D4D RID: 36173
		// (get) Token: 0x06024A45 RID: 150085 RVA: 0x00364087 File Offset: 0x00362287
		// (set) Token: 0x06024A46 RID: 150086 RVA: 0x00364097 File Offset: 0x00362297
		public unsafe float LPVIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVIntensity) = value;
			}
		}

		// Token: 0x17008D4E RID: 36174
		// (get) Token: 0x06024A47 RID: 150087 RVA: 0x003640A8 File Offset: 0x003622A8
		// (set) Token: 0x06024A48 RID: 150088 RVA: 0x003640B8 File Offset: 0x003622B8
		public unsafe float LPVVplInjectionBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVVplInjectionBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVVplInjectionBias) = value;
			}
		}

		// Token: 0x17008D4F RID: 36175
		// (get) Token: 0x06024A49 RID: 150089 RVA: 0x003640C9 File Offset: 0x003622C9
		// (set) Token: 0x06024A4A RID: 150090 RVA: 0x003640D9 File Offset: 0x003622D9
		public unsafe float LPVSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSize) = value;
			}
		}

		// Token: 0x17008D50 RID: 36176
		// (get) Token: 0x06024A4B RID: 150091 RVA: 0x003640EA File Offset: 0x003622EA
		// (set) Token: 0x06024A4C RID: 150092 RVA: 0x003640FA File Offset: 0x003622FA
		public unsafe float LPVSecondaryOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSecondaryOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSecondaryOcclusionIntensity) = value;
			}
		}

		// Token: 0x17008D51 RID: 36177
		// (get) Token: 0x06024A4D RID: 150093 RVA: 0x0036410B File Offset: 0x0036230B
		// (set) Token: 0x06024A4E RID: 150094 RVA: 0x0036411B File Offset: 0x0036231B
		public unsafe float LPVSecondaryBounceIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSecondaryBounceIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSecondaryBounceIntensity) = value;
			}
		}

		// Token: 0x17008D52 RID: 36178
		// (get) Token: 0x06024A4F RID: 150095 RVA: 0x0036412C File Offset: 0x0036232C
		// (set) Token: 0x06024A50 RID: 150096 RVA: 0x0036413C File Offset: 0x0036233C
		public unsafe float LPVGeometryVolumeBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVGeometryVolumeBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVGeometryVolumeBias) = value;
			}
		}

		// Token: 0x17008D53 RID: 36179
		// (get) Token: 0x06024A51 RID: 150097 RVA: 0x0036414D File Offset: 0x0036234D
		// (set) Token: 0x06024A52 RID: 150098 RVA: 0x0036415D File Offset: 0x0036235D
		public unsafe float LPVEmissiveInjectionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVEmissiveInjectionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVEmissiveInjectionIntensity) = value;
			}
		}

		// Token: 0x17008D54 RID: 36180
		// (get) Token: 0x06024A53 RID: 150099 RVA: 0x0036416E File Offset: 0x0036236E
		// (set) Token: 0x06024A54 RID: 150100 RVA: 0x0036417E File Offset: 0x0036237E
		public unsafe float LPVDirectionalOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDirectionalOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDirectionalOcclusionIntensity) = value;
			}
		}

		// Token: 0x17008D55 RID: 36181
		// (get) Token: 0x06024A55 RID: 150101 RVA: 0x0036418F File Offset: 0x0036238F
		// (set) Token: 0x06024A56 RID: 150102 RVA: 0x0036419F File Offset: 0x0036239F
		public unsafe float LPVDirectionalOcclusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDirectionalOcclusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDirectionalOcclusionRadius) = value;
			}
		}

		// Token: 0x17008D56 RID: 36182
		// (get) Token: 0x06024A57 RID: 150103 RVA: 0x003641B0 File Offset: 0x003623B0
		// (set) Token: 0x06024A58 RID: 150104 RVA: 0x003641C0 File Offset: 0x003623C0
		public unsafe float LPVDiffuseOcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDiffuseOcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDiffuseOcclusionExponent) = value;
			}
		}

		// Token: 0x17008D57 RID: 36183
		// (get) Token: 0x06024A59 RID: 150105 RVA: 0x003641D1 File Offset: 0x003623D1
		// (set) Token: 0x06024A5A RID: 150106 RVA: 0x003641E1 File Offset: 0x003623E1
		public unsafe float LPVSpecularOcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSpecularOcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSpecularOcclusionExponent) = value;
			}
		}

		// Token: 0x17008D58 RID: 36184
		// (get) Token: 0x06024A5B RID: 150107 RVA: 0x003641F2 File Offset: 0x003623F2
		// (set) Token: 0x06024A5C RID: 150108 RVA: 0x00364202 File Offset: 0x00362402
		public unsafe float LPVDiffuseOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDiffuseOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDiffuseOcclusionIntensity) = value;
			}
		}

		// Token: 0x17008D59 RID: 36185
		// (get) Token: 0x06024A5D RID: 150109 RVA: 0x00364213 File Offset: 0x00362413
		// (set) Token: 0x06024A5E RID: 150110 RVA: 0x00364223 File Offset: 0x00362423
		public unsafe float LPVSpecularOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSpecularOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVSpecularOcclusionIntensity) = value;
			}
		}

		// Token: 0x17008D5A RID: 36186
		// (get) Token: 0x06024A5F RID: 150111 RVA: 0x00364234 File Offset: 0x00362434
		// (set) Token: 0x06024A60 RID: 150112 RVA: 0x00364244 File Offset: 0x00362444
		public unsafe float LPVFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVFadeRange) = value;
			}
		}

		// Token: 0x17008D5B RID: 36187
		// (get) Token: 0x06024A61 RID: 150113 RVA: 0x00364255 File Offset: 0x00362455
		// (set) Token: 0x06024A62 RID: 150114 RVA: 0x00364265 File Offset: 0x00362465
		public unsafe float LPVDirectionalOcclusionFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDirectionalOcclusionFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightPropagationVolumeSettings.__PropertyOffset_LPVDirectionalOcclusionFadeRange) = value;
			}
		}

		// Token: 0x06024A63 RID: 150115 RVA: 0x00364276 File Offset: 0x00362476
		public FLightPropagationVolumeSettings()
		{
		}

		// Token: 0x06024A64 RID: 150116 RVA: 0x00364280 File Offset: 0x00362480
		public FLightPropagationVolumeSettings(bool bOverride_LPVIntensity, bool bOverride_LPVDirectionalOcclusionIntensity, bool bOverride_LPVDirectionalOcclusionRadius, bool bOverride_LPVDiffuseOcclusionExponent, bool bOverride_LPVSpecularOcclusionExponent, bool bOverride_LPVDiffuseOcclusionIntensity, bool bOverride_LPVSpecularOcclusionIntensity, bool bOverride_LPVSize, bool bOverride_LPVSecondaryOcclusionIntensity, bool bOverride_LPVSecondaryBounceIntensity, bool bOverride_LPVGeometryVolumeBias, bool bOverride_LPVVplInjectionBias, bool bOverride_LPVEmissiveInjectionIntensity, float LPVIntensity, float LPVVplInjectionBias, float LPVSize, float LPVSecondaryOcclusionIntensity, float LPVSecondaryBounceIntensity, float LPVGeometryVolumeBias, float LPVEmissiveInjectionIntensity, float LPVDirectionalOcclusionIntensity, float LPVDirectionalOcclusionRadius, float LPVDiffuseOcclusionExponent, float LPVSpecularOcclusionExponent, float LPVDiffuseOcclusionIntensity, float LPVSpecularOcclusionIntensity, float LPVFadeRange, float LPVDirectionalOcclusionFadeRange)
		{
			this.bOverride_LPVIntensity = bOverride_LPVIntensity;
			this.bOverride_LPVDirectionalOcclusionIntensity = bOverride_LPVDirectionalOcclusionIntensity;
			this.bOverride_LPVDirectionalOcclusionRadius = bOverride_LPVDirectionalOcclusionRadius;
			this.bOverride_LPVDiffuseOcclusionExponent = bOverride_LPVDiffuseOcclusionExponent;
			this.bOverride_LPVSpecularOcclusionExponent = bOverride_LPVSpecularOcclusionExponent;
			this.bOverride_LPVDiffuseOcclusionIntensity = bOverride_LPVDiffuseOcclusionIntensity;
			this.bOverride_LPVSpecularOcclusionIntensity = bOverride_LPVSpecularOcclusionIntensity;
			this.bOverride_LPVSize = bOverride_LPVSize;
			this.bOverride_LPVSecondaryOcclusionIntensity = bOverride_LPVSecondaryOcclusionIntensity;
			this.bOverride_LPVSecondaryBounceIntensity = bOverride_LPVSecondaryBounceIntensity;
			this.bOverride_LPVGeometryVolumeBias = bOverride_LPVGeometryVolumeBias;
			this.bOverride_LPVVplInjectionBias = bOverride_LPVVplInjectionBias;
			this.bOverride_LPVEmissiveInjectionIntensity = bOverride_LPVEmissiveInjectionIntensity;
			this.LPVIntensity = LPVIntensity;
			this.LPVVplInjectionBias = LPVVplInjectionBias;
			this.LPVSize = LPVSize;
			this.LPVSecondaryOcclusionIntensity = LPVSecondaryOcclusionIntensity;
			this.LPVSecondaryBounceIntensity = LPVSecondaryBounceIntensity;
			this.LPVGeometryVolumeBias = LPVGeometryVolumeBias;
			this.LPVEmissiveInjectionIntensity = LPVEmissiveInjectionIntensity;
			this.LPVDirectionalOcclusionIntensity = LPVDirectionalOcclusionIntensity;
			this.LPVDirectionalOcclusionRadius = LPVDirectionalOcclusionRadius;
			this.LPVDiffuseOcclusionExponent = LPVDiffuseOcclusionExponent;
			this.LPVSpecularOcclusionExponent = LPVSpecularOcclusionExponent;
			this.LPVDiffuseOcclusionIntensity = LPVDiffuseOcclusionIntensity;
			this.LPVSpecularOcclusionIntensity = LPVSpecularOcclusionIntensity;
			this.LPVFadeRange = LPVFadeRange;
			this.LPVDirectionalOcclusionFadeRange = LPVDirectionalOcclusionFadeRange;
		}

		// Token: 0x06024A65 RID: 150117 RVA: 0x00364370 File Offset: 0x00362570
		protected override IntPtr GetUStructPtr()
		{
			return FLightPropagationVolumeSettings.StaticStruct();
		}

		// Token: 0x06024A66 RID: 150118 RVA: 0x0036437C File Offset: 0x0036257C
		[NullableContext(2)]
		public FLightPropagationVolumeSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024A67 RID: 150119 RVA: 0x00364386 File Offset: 0x00362586
		public FLightPropagationVolumeSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024A68 RID: 150120 RVA: 0x00364391 File Offset: 0x00362591
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightPropagationVolumeSettings(Pointer, false, true);
		}

		// Token: 0x06024A69 RID: 150121 RVA: 0x0036439B File Offset: 0x0036259B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightPropagationVolumeSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04013B27 RID: 80679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.LightPropagationVolumeSettings";

		// Token: 0x04013B28 RID: 80680
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B29 RID: 80681
		internal static int __PropertyOffset_bOverride_LPVIntensity;

		// Token: 0x04013B2A RID: 80682
		internal static byte __PropertyMask_bOverride_LPVIntensity;

		// Token: 0x04013B2B RID: 80683
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity;

		// Token: 0x04013B2C RID: 80684
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionIntensity;

		// Token: 0x04013B2D RID: 80685
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionRadius;

		// Token: 0x04013B2E RID: 80686
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionRadius;

		// Token: 0x04013B2F RID: 80687
		internal static int __PropertyOffset_bOverride_LPVDiffuseOcclusionExponent;

		// Token: 0x04013B30 RID: 80688
		internal static byte __PropertyMask_bOverride_LPVDiffuseOcclusionExponent;

		// Token: 0x04013B31 RID: 80689
		internal static int __PropertyOffset_bOverride_LPVSpecularOcclusionExponent;

		// Token: 0x04013B32 RID: 80690
		internal static byte __PropertyMask_bOverride_LPVSpecularOcclusionExponent;

		// Token: 0x04013B33 RID: 80691
		internal static int __PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity;

		// Token: 0x04013B34 RID: 80692
		internal static byte __PropertyMask_bOverride_LPVDiffuseOcclusionIntensity;

		// Token: 0x04013B35 RID: 80693
		internal static int __PropertyOffset_bOverride_LPVSpecularOcclusionIntensity;

		// Token: 0x04013B36 RID: 80694
		internal static byte __PropertyMask_bOverride_LPVSpecularOcclusionIntensity;

		// Token: 0x04013B37 RID: 80695
		internal static int __PropertyOffset_bOverride_LPVSize;

		// Token: 0x04013B38 RID: 80696
		internal static byte __PropertyMask_bOverride_LPVSize;

		// Token: 0x04013B39 RID: 80697
		internal static int __PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity;

		// Token: 0x04013B3A RID: 80698
		internal static byte __PropertyMask_bOverride_LPVSecondaryOcclusionIntensity;

		// Token: 0x04013B3B RID: 80699
		internal static int __PropertyOffset_bOverride_LPVSecondaryBounceIntensity;

		// Token: 0x04013B3C RID: 80700
		internal static byte __PropertyMask_bOverride_LPVSecondaryBounceIntensity;

		// Token: 0x04013B3D RID: 80701
		internal static int __PropertyOffset_bOverride_LPVGeometryVolumeBias;

		// Token: 0x04013B3E RID: 80702
		internal static byte __PropertyMask_bOverride_LPVGeometryVolumeBias;

		// Token: 0x04013B3F RID: 80703
		internal static int __PropertyOffset_bOverride_LPVVplInjectionBias;

		// Token: 0x04013B40 RID: 80704
		internal static byte __PropertyMask_bOverride_LPVVplInjectionBias;

		// Token: 0x04013B41 RID: 80705
		internal static int __PropertyOffset_bOverride_LPVEmissiveInjectionIntensity;

		// Token: 0x04013B42 RID: 80706
		internal static byte __PropertyMask_bOverride_LPVEmissiveInjectionIntensity;

		// Token: 0x04013B43 RID: 80707
		internal static int __PropertyOffset_LPVIntensity;

		// Token: 0x04013B44 RID: 80708
		internal static int __PropertyOffset_LPVVplInjectionBias;

		// Token: 0x04013B45 RID: 80709
		internal static int __PropertyOffset_LPVSize;

		// Token: 0x04013B46 RID: 80710
		internal static int __PropertyOffset_LPVSecondaryOcclusionIntensity;

		// Token: 0x04013B47 RID: 80711
		internal static int __PropertyOffset_LPVSecondaryBounceIntensity;

		// Token: 0x04013B48 RID: 80712
		internal static int __PropertyOffset_LPVGeometryVolumeBias;

		// Token: 0x04013B49 RID: 80713
		internal static int __PropertyOffset_LPVEmissiveInjectionIntensity;

		// Token: 0x04013B4A RID: 80714
		internal static int __PropertyOffset_LPVDirectionalOcclusionIntensity;

		// Token: 0x04013B4B RID: 80715
		internal static int __PropertyOffset_LPVDirectionalOcclusionRadius;

		// Token: 0x04013B4C RID: 80716
		internal static int __PropertyOffset_LPVDiffuseOcclusionExponent;

		// Token: 0x04013B4D RID: 80717
		internal static int __PropertyOffset_LPVSpecularOcclusionExponent;

		// Token: 0x04013B4E RID: 80718
		internal static int __PropertyOffset_LPVDiffuseOcclusionIntensity;

		// Token: 0x04013B4F RID: 80719
		internal static int __PropertyOffset_LPVSpecularOcclusionIntensity;

		// Token: 0x04013B50 RID: 80720
		internal static int __PropertyOffset_LPVFadeRange;

		// Token: 0x04013B51 RID: 80721
		internal static int __PropertyOffset_LPVDirectionalOcclusionFadeRange;
	}
}
