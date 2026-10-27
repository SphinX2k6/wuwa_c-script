using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001236 RID: 4662
	[UnrealObjectPath("/Script/Engine.VisibilityTrackKey")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FVisibilityTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601123D RID: 70205 RVA: 0x00192641 File Offset: 0x00190841
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVisibilityTrackKey._ScriptStructPtr != 0) ? FVisibilityTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VisibilityTrackKey", ref FVisibilityTrackKey._ScriptStructPtr);
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x0601123E RID: 70206 RVA: 0x00192665 File Offset: 0x00190865
		// (set) Token: 0x0601123F RID: 70207 RVA: 0x00192675 File Offset: 0x00190875
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilityTrackKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilityTrackKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x06011240 RID: 70208 RVA: 0x00192686 File Offset: 0x00190886
		// (set) Token: 0x06011241 RID: 70209 RVA: 0x0019269A File Offset: 0x0019089A
		public unsafe TEnumAsByte<EVisibilityTrackAction> Action
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilityTrackKey.__PropertyOffset_Action);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilityTrackKey.__PropertyOffset_Action) = value;
			}
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x06011242 RID: 70210 RVA: 0x001926AF File Offset: 0x001908AF
		// (set) Token: 0x06011243 RID: 70211 RVA: 0x001926C3 File Offset: 0x001908C3
		public unsafe TEnumAsByte<EVisibilityTrackCondition> ActiveCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilityTrackKey.__PropertyOffset_ActiveCondition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilityTrackKey.__PropertyOffset_ActiveCondition) = value;
			}
		}

		// Token: 0x06011244 RID: 70212 RVA: 0x001926D8 File Offset: 0x001908D8
		public FVisibilityTrackKey()
		{
		}

		// Token: 0x06011245 RID: 70213 RVA: 0x001926E0 File Offset: 0x001908E0
		public FVisibilityTrackKey(float Time, TEnumAsByte<EVisibilityTrackAction> Action, TEnumAsByte<EVisibilityTrackCondition> ActiveCondition)
		{
			this.Time = Time;
			this.Action = Action;
			this.ActiveCondition = ActiveCondition;
		}

		// Token: 0x06011246 RID: 70214 RVA: 0x001926FD File Offset: 0x001908FD
		protected override IntPtr GetUStructPtr()
		{
			return FVisibilityTrackKey.StaticStruct();
		}

		// Token: 0x06011247 RID: 70215 RVA: 0x00192709 File Offset: 0x00190909
		[NullableContext(2)]
		public FVisibilityTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011248 RID: 70216 RVA: 0x00192713 File Offset: 0x00190913
		public FVisibilityTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011249 RID: 70217 RVA: 0x0019271E File Offset: 0x0019091E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVisibilityTrackKey(Pointer, false, true);
		}

		// Token: 0x0601124A RID: 70218 RVA: 0x00192728 File Offset: 0x00190928
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVisibilityTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x040092C3 RID: 37571
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VisibilityTrackKey";

		// Token: 0x040092C4 RID: 37572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040092C5 RID: 37573
		internal static int __PropertyOffset_Time;

		// Token: 0x040092C6 RID: 37574
		internal static int __PropertyOffset_Action;

		// Token: 0x040092C7 RID: 37575
		internal static int __PropertyOffset_ActiveCondition;
	}
}
