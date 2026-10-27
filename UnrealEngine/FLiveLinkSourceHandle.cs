using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002217 RID: 8727
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSourceHandle")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLiveLinkSourceHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213DB RID: 136155 RVA: 0x003100D5 File Offset: 0x0030E2D5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSourceHandle._ScriptStructPtr != 0) ? FLiveLinkSourceHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSourceHandle", ref FLiveLinkSourceHandle._ScriptStructPtr);
		}

		// Token: 0x060213DC RID: 136156 RVA: 0x003100F9 File Offset: 0x0030E2F9
		public FLiveLinkSourceHandle()
		{
		}

		// Token: 0x060213DD RID: 136157 RVA: 0x00310101 File Offset: 0x0030E301
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSourceHandle.StaticStruct();
		}

		// Token: 0x060213DE RID: 136158 RVA: 0x0031010D File Offset: 0x0030E30D
		[NullableContext(2)]
		public FLiveLinkSourceHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213DF RID: 136159 RVA: 0x00310117 File Offset: 0x0030E317
		public FLiveLinkSourceHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213E0 RID: 136160 RVA: 0x00310122 File Offset: 0x0030E322
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSourceHandle(Pointer, false, true);
		}

		// Token: 0x060213E1 RID: 136161 RVA: 0x0031012C File Offset: 0x0030E32C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSourceHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04011BB4 RID: 72628
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSourceHandle";

		// Token: 0x04011BB5 RID: 72629
		private static IntPtr _ScriptStructPtr;
	}
}
