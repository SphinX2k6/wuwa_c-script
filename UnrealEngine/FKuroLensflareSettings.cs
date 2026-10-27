using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200268D RID: 9869
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.KuroLensflareSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroLensflareSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024A13 RID: 150035 RVA: 0x00363AC9 File Offset: 0x00361CC9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLensflareSettings._ScriptStructPtr != 0) ? FKuroLensflareSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.KuroLensflareSettings", ref FKuroLensflareSettings._ScriptStructPtr);
		}

		// Token: 0x17008D3B RID: 36155
		// (get) Token: 0x06024A14 RID: 150036 RVA: 0x00363AED File Offset: 0x00361CED
		// (set) Token: 0x06024A15 RID: 150037 RVA: 0x00363AFD File Offset: 0x00361CFD
		public unsafe float PrefilterThresholdLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_PrefilterThresholdLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_PrefilterThresholdLevel) = value;
			}
		}

		// Token: 0x17008D3C RID: 36156
		// (get) Token: 0x06024A16 RID: 150038 RVA: 0x00363B0E File Offset: 0x00361D0E
		// (set) Token: 0x06024A17 RID: 150039 RVA: 0x00363B1E File Offset: 0x00361D1E
		public unsafe float PrefilterThresholdRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_PrefilterThresholdRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_PrefilterThresholdRange) = value;
			}
		}

		// Token: 0x17008D3D RID: 36157
		// (get) Token: 0x06024A18 RID: 150040 RVA: 0x00363B2F File Offset: 0x00361D2F
		// (set) Token: 0x06024A19 RID: 150041 RVA: 0x00363B3F File Offset: 0x00361D3F
		public unsafe float ChromaShift
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_ChromaShift);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_ChromaShift) = value;
			}
		}

		// Token: 0x17008D3E RID: 36158
		// (get) Token: 0x06024A1A RID: 150042 RVA: 0x00363B50 File Offset: 0x00361D50
		// (set) Token: 0x06024A1B RID: 150043 RVA: 0x00363B60 File Offset: 0x00361D60
		public unsafe float LuminanceClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_LuminanceClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_LuminanceClamp) = value;
			}
		}

		// Token: 0x17008D3F RID: 36159
		// (get) Token: 0x06024A1C RID: 150044 RVA: 0x00363B74 File Offset: 0x00361D74
		// (set) Token: 0x06024A1D RID: 150045 RVA: 0x00363BB7 File Offset: 0x00361DB7
		public TArray<FKuroLensflareGhostSetting> GhostSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLensflareGhostSetting> result;
				if ((result = this._GhostSettings) == null)
				{
					result = (this._GhostSettings = new TArray<FKuroLensflareGhostSetting>(base.NativePtr + (IntPtr)FKuroLensflareSettings.__PropertyOffset_GhostSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GhostSettings.CopyAssign(value);
			}
		}

		// Token: 0x06024A1E RID: 150046 RVA: 0x00363BC5 File Offset: 0x00361DC5
		public FKuroLensflareSettings()
		{
		}

		// Token: 0x06024A1F RID: 150047 RVA: 0x00363BCD File Offset: 0x00361DCD
		public FKuroLensflareSettings(float PrefilterThresholdLevel, float PrefilterThresholdRange, float ChromaShift, float LuminanceClamp, TArray<FKuroLensflareGhostSetting> GhostSettings)
		{
			this.PrefilterThresholdLevel = PrefilterThresholdLevel;
			this.PrefilterThresholdRange = PrefilterThresholdRange;
			this.ChromaShift = ChromaShift;
			this.LuminanceClamp = LuminanceClamp;
			this.GhostSettings = GhostSettings;
		}

		// Token: 0x06024A20 RID: 150048 RVA: 0x00363BFA File Offset: 0x00361DFA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLensflareSettings.StaticStruct();
		}

		// Token: 0x06024A21 RID: 150049 RVA: 0x00363C06 File Offset: 0x00361E06
		[NullableContext(2)]
		public FKuroLensflareSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024A22 RID: 150050 RVA: 0x00363C10 File Offset: 0x00361E10
		public FKuroLensflareSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024A23 RID: 150051 RVA: 0x00363C1B File Offset: 0x00361E1B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLensflareSettings(Pointer, false, true);
		}

		// Token: 0x06024A24 RID: 150052 RVA: 0x00363C25 File Offset: 0x00361E25
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLensflareSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04013B1C RID: 80668
		public const string __ObjectPath = "/Script/Renderer.KuroLensflareSettings";

		// Token: 0x04013B1D RID: 80669
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B1E RID: 80670
		internal static int __PropertyOffset_PrefilterThresholdLevel;

		// Token: 0x04013B1F RID: 80671
		internal static int __PropertyOffset_PrefilterThresholdRange;

		// Token: 0x04013B20 RID: 80672
		internal static int __PropertyOffset_ChromaShift;

		// Token: 0x04013B21 RID: 80673
		internal static int __PropertyOffset_LuminanceClamp;

		// Token: 0x04013B22 RID: 80674
		internal static int __PropertyOffset_GhostSettings;

		// Token: 0x04013B23 RID: 80675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLensflareGhostSetting> _GhostSettings;
	}
}
