using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F38 RID: 3896
	[UnrealObjectPath("/Script/Engine.OverlapResult")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FOverlapResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D215 RID: 53781 RVA: 0x00133E84 File Offset: 0x00132084
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOverlapResult._ScriptStructPtr != 0) ? FOverlapResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.OverlapResult", ref FOverlapResult._ScriptStructPtr);
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600D216 RID: 53782 RVA: 0x00133EA8 File Offset: 0x001320A8
		// (set) Token: 0x0600D217 RID: 53783 RVA: 0x00133EBC File Offset: 0x001320BC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Actor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_Actor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_Actor) = value;
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600D218 RID: 53784 RVA: 0x00133ED1 File Offset: 0x001320D1
		// (set) Token: 0x0600D219 RID: 53785 RVA: 0x00133EE5 File Offset: 0x001320E5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UPrimitiveComponent> Component
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_Component);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_Component) = value;
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600D21A RID: 53786 RVA: 0x00133EFA File Offset: 0x001320FA
		// (set) Token: 0x0600D21B RID: 53787 RVA: 0x00133F13 File Offset: 0x00132113
		public unsafe bool bBlockingHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_bBlockingHit) & FOverlapResult.__PropertyMask_bBlockingHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_bBlockingHit) = ((*(base.NativePtr + (IntPtr)FOverlapResult.__PropertyOffset_bBlockingHit) & ~FOverlapResult.__PropertyMask_bBlockingHit) | (value ? FOverlapResult.__PropertyMask_bBlockingHit : 0));
			}
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x00133F43 File Offset: 0x00132143
		public FOverlapResult()
		{
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x00133F4B File Offset: 0x0013214B
		public FOverlapResult([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Actor, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UPrimitiveComponent> Component, bool bBlockingHit)
		{
			this.Actor = Actor;
			this.Component = Component;
			this.bBlockingHit = bBlockingHit;
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x00133F68 File Offset: 0x00132168
		protected override IntPtr GetUStructPtr()
		{
			return FOverlapResult.StaticStruct();
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x00133F74 File Offset: 0x00132174
		[NullableContext(2)]
		public FOverlapResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x00133F7E File Offset: 0x0013217E
		public FOverlapResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x00133F89 File Offset: 0x00132189
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOverlapResult(Pointer, false, true);
		}

		// Token: 0x0600D222 RID: 53794 RVA: 0x00133F93 File Offset: 0x00132193
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOverlapResult(Pointer, MemoryOwner);
		}

		// Token: 0x040070C0 RID: 28864
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OverlapResult";

		// Token: 0x040070C1 RID: 28865
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070C2 RID: 28866
		internal static int __PropertyOffset_Actor;

		// Token: 0x040070C3 RID: 28867
		internal static int __PropertyOffset_Component;

		// Token: 0x040070C4 RID: 28868
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x040070C5 RID: 28869
		internal static byte __PropertyMask_bBlockingHit;
	}
}
