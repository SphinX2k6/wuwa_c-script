using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002228 RID: 8744
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTransform")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLiveLinkTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214BF RID: 136383 RVA: 0x0031140E File Offset: 0x0030F60E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTransform._ScriptStructPtr != 0) ? FLiveLinkTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTransform", ref FLiveLinkTransform._ScriptStructPtr);
		}

		// Token: 0x060214C0 RID: 136384 RVA: 0x00311432 File Offset: 0x0030F632
		public FLiveLinkTransform()
		{
		}

		// Token: 0x060214C1 RID: 136385 RVA: 0x0031143A File Offset: 0x0030F63A
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTransform.StaticStruct();
		}

		// Token: 0x060214C2 RID: 136386 RVA: 0x00311446 File Offset: 0x0030F646
		[NullableContext(2)]
		public FLiveLinkTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214C3 RID: 136387 RVA: 0x00311450 File Offset: 0x0030F650
		public FLiveLinkTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214C4 RID: 136388 RVA: 0x0031145B File Offset: 0x0030F65B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTransform(Pointer, false, true);
		}

		// Token: 0x060214C5 RID: 136389 RVA: 0x00311465 File Offset: 0x0030F665
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04011C1B RID: 72731
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTransform";

		// Token: 0x04011C1C RID: 72732
		private static IntPtr _ScriptStructPtr;
	}
}
