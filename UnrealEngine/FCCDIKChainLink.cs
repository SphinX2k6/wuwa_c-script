using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002B7 RID: 695
	[UnrealObjectPath("/Script/AnimationCore.CCDIKChainLink")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FCCDIKChainLink : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026B7 RID: 9911 RVA: 0x0003A382 File Offset: 0x00038582
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCCDIKChainLink._ScriptStructPtr != 0) ? FCCDIKChainLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.CCDIKChainLink", ref FCCDIKChainLink._ScriptStructPtr);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0003A3A6 File Offset: 0x000385A6
		public FCCDIKChainLink()
		{
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0003A3AE File Offset: 0x000385AE
		protected override IntPtr GetUStructPtr()
		{
			return FCCDIKChainLink.StaticStruct();
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0003A3BA File Offset: 0x000385BA
		[NullableContext(2)]
		public FCCDIKChainLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x0003A3C4 File Offset: 0x000385C4
		public FCCDIKChainLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0003A3CF File Offset: 0x000385CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCCDIKChainLink(Pointer, false, true);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0003A3D9 File Offset: 0x000385D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCCDIKChainLink(Pointer, MemoryOwner);
		}

		// Token: 0x04000F36 RID: 3894
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.CCDIKChainLink";

		// Token: 0x04000F37 RID: 3895
		private static IntPtr _ScriptStructPtr;
	}
}
