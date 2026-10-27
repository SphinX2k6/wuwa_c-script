using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001244 RID: 4676
	[UnrealObjectPath("/Script/Engine.WalkableSlopeOverride")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWalkableSlopeOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060112F8 RID: 70392 RVA: 0x001937B5 File Offset: 0x001919B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWalkableSlopeOverride._ScriptStructPtr != 0) ? FWalkableSlopeOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WalkableSlopeOverride", ref FWalkableSlopeOverride._ScriptStructPtr);
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x060112F9 RID: 70393 RVA: 0x001937D9 File Offset: 0x001919D9
		// (set) Token: 0x060112FA RID: 70394 RVA: 0x001937ED File Offset: 0x001919ED
		public unsafe TEnumAsByte<EWalkableSlopeBehavior> WalkableSlopeBehavior
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWalkableSlopeOverride.__PropertyOffset_WalkableSlopeBehavior);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWalkableSlopeOverride.__PropertyOffset_WalkableSlopeBehavior) = value;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x060112FB RID: 70395 RVA: 0x00193802 File Offset: 0x00191A02
		// (set) Token: 0x060112FC RID: 70396 RVA: 0x00193812 File Offset: 0x00191A12
		public unsafe float WalkableSlopeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWalkableSlopeOverride.__PropertyOffset_WalkableSlopeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWalkableSlopeOverride.__PropertyOffset_WalkableSlopeAngle) = value;
			}
		}

		// Token: 0x060112FD RID: 70397 RVA: 0x00193823 File Offset: 0x00191A23
		public FWalkableSlopeOverride()
		{
		}

		// Token: 0x060112FE RID: 70398 RVA: 0x0019382B File Offset: 0x00191A2B
		public FWalkableSlopeOverride(TEnumAsByte<EWalkableSlopeBehavior> WalkableSlopeBehavior, float WalkableSlopeAngle)
		{
			this.WalkableSlopeBehavior = WalkableSlopeBehavior;
			this.WalkableSlopeAngle = WalkableSlopeAngle;
		}

		// Token: 0x060112FF RID: 70399 RVA: 0x00193841 File Offset: 0x00191A41
		protected override IntPtr GetUStructPtr()
		{
			return FWalkableSlopeOverride.StaticStruct();
		}

		// Token: 0x06011300 RID: 70400 RVA: 0x0019384D File Offset: 0x00191A4D
		[NullableContext(2)]
		public FWalkableSlopeOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011301 RID: 70401 RVA: 0x00193857 File Offset: 0x00191A57
		public FWalkableSlopeOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011302 RID: 70402 RVA: 0x00193862 File Offset: 0x00191A62
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWalkableSlopeOverride(Pointer, false, true);
		}

		// Token: 0x06011303 RID: 70403 RVA: 0x0019386C File Offset: 0x00191A6C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWalkableSlopeOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04009310 RID: 37648
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WalkableSlopeOverride";

		// Token: 0x04009311 RID: 37649
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009312 RID: 37650
		internal static int __PropertyOffset_WalkableSlopeBehavior;

		// Token: 0x04009313 RID: 37651
		internal static int __PropertyOffset_WalkableSlopeAngle;
	}
}
