using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027C9 RID: 10185
	[UnrealObjectPath("/Script/SimplygonUObjects.ParameterizerSettings")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FParameterizerSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025F8E RID: 155534 RVA: 0x0039932F File Offset: 0x0039752F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParameterizerSettings._ScriptStructPtr != 0) ? FParameterizerSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ParameterizerSettings", ref FParameterizerSettings._ScriptStructPtr);
		}

		// Token: 0x17009271 RID: 37489
		// (get) Token: 0x06025F8F RID: 155535 RVA: 0x00399353 File Offset: 0x00397553
		// (set) Token: 0x06025F90 RID: 155536 RVA: 0x00399363 File Offset: 0x00397563
		public unsafe float MaxStretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParameterizerSettings.__PropertyOffset_MaxStretch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParameterizerSettings.__PropertyOffset_MaxStretch) = value;
			}
		}

		// Token: 0x17009272 RID: 37490
		// (get) Token: 0x06025F91 RID: 155537 RVA: 0x00399374 File Offset: 0x00397574
		// (set) Token: 0x06025F92 RID: 155538 RVA: 0x00399384 File Offset: 0x00397584
		public unsafe float LargeChartsImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParameterizerSettings.__PropertyOffset_LargeChartsImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParameterizerSettings.__PropertyOffset_LargeChartsImportance) = value;
			}
		}

		// Token: 0x06025F93 RID: 155539 RVA: 0x00399395 File Offset: 0x00397595
		public FParameterizerSettings()
		{
		}

		// Token: 0x06025F94 RID: 155540 RVA: 0x0039939D File Offset: 0x0039759D
		public FParameterizerSettings(float MaxStretch, float LargeChartsImportance)
		{
			this.MaxStretch = MaxStretch;
			this.LargeChartsImportance = LargeChartsImportance;
		}

		// Token: 0x06025F95 RID: 155541 RVA: 0x003993B3 File Offset: 0x003975B3
		protected override IntPtr GetUStructPtr()
		{
			return FParameterizerSettings.StaticStruct();
		}

		// Token: 0x06025F96 RID: 155542 RVA: 0x003993BF File Offset: 0x003975BF
		[NullableContext(2)]
		public FParameterizerSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025F97 RID: 155543 RVA: 0x003993C9 File Offset: 0x003975C9
		public FParameterizerSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025F98 RID: 155544 RVA: 0x003993D4 File Offset: 0x003975D4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParameterizerSettings(Pointer, false, true);
		}

		// Token: 0x06025F99 RID: 155545 RVA: 0x003993DE File Offset: 0x003975DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParameterizerSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014BA3 RID: 84899
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.ParameterizerSettings";

		// Token: 0x04014BA4 RID: 84900
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BA5 RID: 84901
		internal static int __PropertyOffset_MaxStretch;

		// Token: 0x04014BA6 RID: 84902
		internal static int __PropertyOffset_LargeChartsImportance;
	}
}
