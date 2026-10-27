using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A97 RID: 10903
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseTriggerCookedData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseTriggerCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028304 RID: 164612 RVA: 0x003D244E File Offset: 0x003D064E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseTriggerCookedData._ScriptStructPtr != 0) ? FWwiseTriggerCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseTriggerCookedData", ref FWwiseTriggerCookedData._ScriptStructPtr);
		}

		// Token: 0x17009953 RID: 39251
		// (get) Token: 0x06028305 RID: 164613 RVA: 0x003D2472 File Offset: 0x003D0672
		// (set) Token: 0x06028306 RID: 164614 RVA: 0x003D2482 File Offset: 0x003D0682
		public unsafe int TriggerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseTriggerCookedData.__PropertyOffset_TriggerId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseTriggerCookedData.__PropertyOffset_TriggerId) = value;
			}
		}

		// Token: 0x17009954 RID: 39252
		// (get) Token: 0x06028307 RID: 164615 RVA: 0x003D2493 File Offset: 0x003D0693
		// (set) Token: 0x06028308 RID: 164616 RVA: 0x003D24A7 File Offset: 0x003D06A7
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseTriggerCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseTriggerCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x06028309 RID: 164617 RVA: 0x003D24BC File Offset: 0x003D06BC
		public FWwiseTriggerCookedData()
		{
		}

		// Token: 0x0602830A RID: 164618 RVA: 0x003D24C4 File Offset: 0x003D06C4
		public FWwiseTriggerCookedData(int TriggerId, FName DebugName)
		{
			this.TriggerId = TriggerId;
			this.DebugName = DebugName;
		}

		// Token: 0x0602830B RID: 164619 RVA: 0x003D24DA File Offset: 0x003D06DA
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseTriggerCookedData.StaticStruct();
		}

		// Token: 0x0602830C RID: 164620 RVA: 0x003D24E6 File Offset: 0x003D06E6
		[NullableContext(2)]
		public FWwiseTriggerCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602830D RID: 164621 RVA: 0x003D24F0 File Offset: 0x003D06F0
		public FWwiseTriggerCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602830E RID: 164622 RVA: 0x003D24FB File Offset: 0x003D06FB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseTriggerCookedData(Pointer, false, true);
		}

		// Token: 0x0602830F RID: 164623 RVA: 0x003D2505 File Offset: 0x003D0705
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseTriggerCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x0401609D RID: 90269
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseTriggerCookedData";

		// Token: 0x0401609E RID: 90270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401609F RID: 90271
		internal static int __PropertyOffset_TriggerId;

		// Token: 0x040160A0 RID: 90272
		internal static int __PropertyOffset_DebugName;
	}
}
