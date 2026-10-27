using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014BC RID: 5308
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniBakedOutputObjectIdentifier")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FHoudiniBakedOutputObjectIdentifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013362 RID: 78690 RVA: 0x001C4284 File Offset: 0x001C2484
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniBakedOutputObjectIdentifier._ScriptStructPtr != 0) ? FHoudiniBakedOutputObjectIdentifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniBakedOutputObjectIdentifier", ref FHoudiniBakedOutputObjectIdentifier._ScriptStructPtr);
		}

		// Token: 0x17004AB6 RID: 19126
		// (get) Token: 0x06013363 RID: 78691 RVA: 0x001C42A8 File Offset: 0x001C24A8
		// (set) Token: 0x06013364 RID: 78692 RVA: 0x001C42B8 File Offset: 0x001C24B8
		public unsafe int PartId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBakedOutputObjectIdentifier.__PropertyOffset_PartId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBakedOutputObjectIdentifier.__PropertyOffset_PartId) = value;
			}
		}

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x06013365 RID: 78693 RVA: 0x001C42C9 File Offset: 0x001C24C9
		// (set) Token: 0x06013366 RID: 78694 RVA: 0x001C42DD File Offset: 0x001C24DD
		public unsafe string SplitIdentifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObjectIdentifier.__PropertyOffset_SplitIdentifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObjectIdentifier.__PropertyOffset_SplitIdentifier)), value);
			}
		}

		// Token: 0x06013367 RID: 78695 RVA: 0x001C42F2 File Offset: 0x001C24F2
		public FHoudiniBakedOutputObjectIdentifier()
		{
		}

		// Token: 0x06013368 RID: 78696 RVA: 0x001C42FA File Offset: 0x001C24FA
		public FHoudiniBakedOutputObjectIdentifier(int PartId, string SplitIdentifier)
		{
			this.PartId = PartId;
			this.SplitIdentifier = SplitIdentifier;
		}

		// Token: 0x06013369 RID: 78697 RVA: 0x001C4310 File Offset: 0x001C2510
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniBakedOutputObjectIdentifier.StaticStruct();
		}

		// Token: 0x0601336A RID: 78698 RVA: 0x001C431C File Offset: 0x001C251C
		[NullableContext(2)]
		public FHoudiniBakedOutputObjectIdentifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601336B RID: 78699 RVA: 0x001C4326 File Offset: 0x001C2526
		public FHoudiniBakedOutputObjectIdentifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601336C RID: 78700 RVA: 0x001C4331 File Offset: 0x001C2531
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniBakedOutputObjectIdentifier(Pointer, false, true);
		}

		// Token: 0x0601336D RID: 78701 RVA: 0x001C433B File Offset: 0x001C253B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniBakedOutputObjectIdentifier(Pointer, MemoryOwner);
		}

		// Token: 0x0400A604 RID: 42500
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniBakedOutputObjectIdentifier";

		// Token: 0x0400A605 RID: 42501
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A606 RID: 42502
		internal static int __PropertyOffset_PartId;

		// Token: 0x0400A607 RID: 42503
		internal static int __PropertyOffset_SplitIdentifier;
	}
}
