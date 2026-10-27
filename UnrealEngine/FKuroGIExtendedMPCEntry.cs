using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B06 RID: 6918
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGIExtendedMPCEntry")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FKuroGIExtendedMPCEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019E84 RID: 106116 RVA: 0x00263CE5 File Offset: 0x00261EE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGIExtendedMPCEntry._ScriptStructPtr != 0) ? FKuroGIExtendedMPCEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGIExtendedMPCEntry", ref FKuroGIExtendedMPCEntry._ScriptStructPtr);
		}

		// Token: 0x170067D2 RID: 26578
		// (get) Token: 0x06019E85 RID: 106117 RVA: 0x00263D09 File Offset: 0x00261F09
		// (set) Token: 0x06019E86 RID: 106118 RVA: 0x00263D1D File Offset: 0x00261F1D
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGIExtendedMPCEntry.__PropertyOffset_MPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGIExtendedMPCEntry.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x170067D3 RID: 26579
		// (get) Token: 0x06019E87 RID: 106119 RVA: 0x00263D32 File Offset: 0x00261F32
		// (set) Token: 0x06019E88 RID: 106120 RVA: 0x00263D4B File Offset: 0x00261F4B
		public unsafe bool bOverride_FloatParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_bOverride_FloatParameters) & FKuroGIExtendedMPCEntry.__PropertyMask_bOverride_FloatParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_bOverride_FloatParameters) = ((*(base.NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_bOverride_FloatParameters) & ~FKuroGIExtendedMPCEntry.__PropertyMask_bOverride_FloatParameters) | (value ? FKuroGIExtendedMPCEntry.__PropertyMask_bOverride_FloatParameters : 0));
			}
		}

		// Token: 0x170067D4 RID: 26580
		// (get) Token: 0x06019E89 RID: 106121 RVA: 0x00263D7C File Offset: 0x00261F7C
		// (set) Token: 0x06019E8A RID: 106122 RVA: 0x00263DBF File Offset: 0x00261FBF
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170067D5 RID: 26581
		// (get) Token: 0x06019E8B RID: 106123 RVA: 0x00263DCD File Offset: 0x00261FCD
		// (set) Token: 0x06019E8C RID: 106124 RVA: 0x00263DE6 File Offset: 0x00261FE6
		public unsafe bool bOverride_ColorParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_bOverride_ColorParameters) & FKuroGIExtendedMPCEntry.__PropertyMask_bOverride_ColorParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_bOverride_ColorParameters) = ((*(base.NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_bOverride_ColorParameters) & ~FKuroGIExtendedMPCEntry.__PropertyMask_bOverride_ColorParameters) | (value ? FKuroGIExtendedMPCEntry.__PropertyMask_bOverride_ColorParameters : 0));
			}
		}

		// Token: 0x170067D6 RID: 26582
		// (get) Token: 0x06019E8D RID: 106125 RVA: 0x00263E18 File Offset: 0x00262018
		// (set) Token: 0x06019E8E RID: 106126 RVA: 0x00263E5B File Offset: 0x0026205B
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroGIExtendedMPCEntry.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06019E8F RID: 106127 RVA: 0x00263E69 File Offset: 0x00262069
		public FKuroGIExtendedMPCEntry()
		{
		}

		// Token: 0x06019E90 RID: 106128 RVA: 0x00263E71 File Offset: 0x00262071
		public FKuroGIExtendedMPCEntry(UMaterialParameterCollection MPC, bool bOverride_FloatParameters, TMap<FName, float> FloatParameters, bool bOverride_ColorParameters, TMap<FName, FLinearColor> ColorParameters)
		{
			this.MPC = MPC;
			this.bOverride_FloatParameters = bOverride_FloatParameters;
			this.FloatParameters = FloatParameters;
			this.bOverride_ColorParameters = bOverride_ColorParameters;
			this.ColorParameters = ColorParameters;
		}

		// Token: 0x06019E91 RID: 106129 RVA: 0x00263E9E File Offset: 0x0026209E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGIExtendedMPCEntry.StaticStruct();
		}

		// Token: 0x06019E92 RID: 106130 RVA: 0x00263EAA File Offset: 0x002620AA
		[NullableContext(2)]
		public FKuroGIExtendedMPCEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019E93 RID: 106131 RVA: 0x00263EB4 File Offset: 0x002620B4
		public FKuroGIExtendedMPCEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019E94 RID: 106132 RVA: 0x00263EBF File Offset: 0x002620BF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGIExtendedMPCEntry(Pointer, false, true);
		}

		// Token: 0x06019E95 RID: 106133 RVA: 0x00263EC9 File Offset: 0x002620C9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGIExtendedMPCEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400E14B RID: 57675
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGIExtendedMPCEntry";

		// Token: 0x0400E14C RID: 57676
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E14D RID: 57677
		internal static int __PropertyOffset_MPC;

		// Token: 0x0400E14E RID: 57678
		internal static int __PropertyOffset_bOverride_FloatParameters;

		// Token: 0x0400E14F RID: 57679
		internal static byte __PropertyMask_bOverride_FloatParameters;

		// Token: 0x0400E150 RID: 57680
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400E151 RID: 57681
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x0400E152 RID: 57682
		internal static int __PropertyOffset_bOverride_ColorParameters;

		// Token: 0x0400E153 RID: 57683
		internal static byte __PropertyMask_bOverride_ColorParameters;

		// Token: 0x0400E154 RID: 57684
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400E155 RID: 57685
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;
	}
}
