using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A4F RID: 6735
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.AnomaliesParameters")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAnomaliesParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018E23 RID: 101923 RVA: 0x0024CAE5 File Offset: 0x0024ACE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnomaliesParameters._ScriptStructPtr != 0) ? FAnomaliesParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.AnomaliesParameters", ref FAnomaliesParameters._ScriptStructPtr);
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x06018E24 RID: 101924 RVA: 0x0024CB09 File Offset: 0x0024AD09
		// (set) Token: 0x06018E25 RID: 101925 RVA: 0x0024CB19 File Offset: 0x0024AD19
		public unsafe bool bRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_bRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_bRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700627B RID: 25211
		// (get) Token: 0x06018E26 RID: 101926 RVA: 0x0024CB2A File Offset: 0x0024AD2A
		// (set) Token: 0x06018E27 RID: 101927 RVA: 0x0024CB3E File Offset: 0x0024AD3E
		public unsafe UTexture Color
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FAnomaliesParameters.__PropertyOffset_Color);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnomaliesParameters.__PropertyOffset_Color, value);
			}
		}

		// Token: 0x1700627C RID: 25212
		// (get) Token: 0x06018E28 RID: 101928 RVA: 0x0024CB53 File Offset: 0x0024AD53
		// (set) Token: 0x06018E29 RID: 101929 RVA: 0x0024CB67 File Offset: 0x0024AD67
		public unsafe UTexture NoiseMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FAnomaliesParameters.__PropertyOffset_NoiseMap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnomaliesParameters.__PropertyOffset_NoiseMap, value);
			}
		}

		// Token: 0x1700627D RID: 25213
		// (get) Token: 0x06018E2A RID: 101930 RVA: 0x0024CB7C File Offset: 0x0024AD7C
		// (set) Token: 0x06018E2B RID: 101931 RVA: 0x0024CB90 File Offset: 0x0024AD90
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FAnomaliesParameters.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnomaliesParameters.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x1700627E RID: 25214
		// (get) Token: 0x06018E2C RID: 101932 RVA: 0x0024CBA5 File Offset: 0x0024ADA5
		// (set) Token: 0x06018E2D RID: 101933 RVA: 0x0024CBB5 File Offset: 0x0024ADB5
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_CloudAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_CloudAngle) = value;
			}
		}

		// Token: 0x1700627F RID: 25215
		// (get) Token: 0x06018E2E RID: 101934 RVA: 0x0024CBC6 File Offset: 0x0024ADC6
		// (set) Token: 0x06018E2F RID: 101935 RVA: 0x0024CBD6 File Offset: 0x0024ADD6
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_NoiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_NoiseSpeed) = value;
			}
		}

		// Token: 0x17006280 RID: 25216
		// (get) Token: 0x06018E30 RID: 101936 RVA: 0x0024CBE7 File Offset: 0x0024ADE7
		// (set) Token: 0x06018E31 RID: 101937 RVA: 0x0024CBF7 File Offset: 0x0024ADF7
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_NoiseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_NoiseStrength) = value;
			}
		}

		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x06018E32 RID: 101938 RVA: 0x0024CC08 File Offset: 0x0024AE08
		// (set) Token: 0x06018E33 RID: 101939 RVA: 0x0024CC18 File Offset: 0x0024AE18
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_NoiseTilling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_NoiseTilling) = value;
			}
		}

		// Token: 0x17006282 RID: 25218
		// (get) Token: 0x06018E34 RID: 101940 RVA: 0x0024CC29 File Offset: 0x0024AE29
		// (set) Token: 0x06018E35 RID: 101941 RVA: 0x0024CC39 File Offset: 0x0024AE39
		public unsafe float Luminance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_Luminance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnomaliesParameters.__PropertyOffset_Luminance) = value;
			}
		}

		// Token: 0x06018E36 RID: 101942 RVA: 0x0024CC4A File Offset: 0x0024AE4A
		public FAnomaliesParameters()
		{
		}

		// Token: 0x06018E37 RID: 101943 RVA: 0x0024CC54 File Offset: 0x0024AE54
		[NullableContext(1)]
		public FAnomaliesParameters(bool bRotation, UTexture Color, UTexture NoiseMap, UStaticMesh Mesh, float CloudAngle, float NoiseSpeed, float NoiseStrength, float NoiseTilling, float Luminance)
		{
			this.bRotation = bRotation;
			this.Color = Color;
			this.NoiseMap = NoiseMap;
			this.Mesh = Mesh;
			this.CloudAngle = CloudAngle;
			this.NoiseSpeed = NoiseSpeed;
			this.NoiseStrength = NoiseStrength;
			this.NoiseTilling = NoiseTilling;
			this.Luminance = Luminance;
		}

		// Token: 0x06018E38 RID: 101944 RVA: 0x0024CCAC File Offset: 0x0024AEAC
		protected override IntPtr GetUStructPtr()
		{
			return FAnomaliesParameters.StaticStruct();
		}

		// Token: 0x06018E39 RID: 101945 RVA: 0x0024CCB8 File Offset: 0x0024AEB8
		public FAnomaliesParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018E3A RID: 101946 RVA: 0x0024CCC2 File Offset: 0x0024AEC2
		public FAnomaliesParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018E3B RID: 101947 RVA: 0x0024CCCD File Offset: 0x0024AECD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnomaliesParameters(Pointer, false, true);
		}

		// Token: 0x06018E3C RID: 101948 RVA: 0x0024CCD7 File Offset: 0x0024AED7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnomaliesParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400D76F RID: 55151
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.AnomaliesParameters";

		// Token: 0x0400D770 RID: 55152
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D771 RID: 55153
		internal static int __PropertyOffset_bRotation;

		// Token: 0x0400D772 RID: 55154
		internal static int __PropertyOffset_Color;

		// Token: 0x0400D773 RID: 55155
		internal static int __PropertyOffset_NoiseMap;

		// Token: 0x0400D774 RID: 55156
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400D775 RID: 55157
		internal static int __PropertyOffset_CloudAngle;

		// Token: 0x0400D776 RID: 55158
		internal static int __PropertyOffset_NoiseSpeed;

		// Token: 0x0400D777 RID: 55159
		internal static int __PropertyOffset_NoiseStrength;

		// Token: 0x0400D778 RID: 55160
		internal static int __PropertyOffset_NoiseTilling;

		// Token: 0x0400D779 RID: 55161
		internal static int __PropertyOffset_Luminance;
	}
}
