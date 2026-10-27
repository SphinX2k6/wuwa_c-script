using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001849 RID: 6217
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroInstigator")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroInstigator : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016EAB RID: 93867 RVA: 0x0021706A File Offset: 0x0021526A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInstigator._ScriptStructPtr != 0) ? FKuroInstigator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroFauxPhysics.KuroInstigator", ref FKuroInstigator._ScriptStructPtr);
		}

		// Token: 0x06016EAC RID: 93868 RVA: 0x0021708E File Offset: 0x0021528E
		public FKuroInstigator()
		{
		}

		// Token: 0x06016EAD RID: 93869 RVA: 0x00217096 File Offset: 0x00215296
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInstigator.StaticStruct();
		}

		// Token: 0x06016EAE RID: 93870 RVA: 0x002170A2 File Offset: 0x002152A2
		[NullableContext(2)]
		public FKuroInstigator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016EAF RID: 93871 RVA: 0x002170AC File Offset: 0x002152AC
		public FKuroInstigator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016EB0 RID: 93872 RVA: 0x002170B7 File Offset: 0x002152B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInstigator(Pointer, false, true);
		}

		// Token: 0x06016EB1 RID: 93873 RVA: 0x002170C1 File Offset: 0x002152C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInstigator(Pointer, MemoryOwner);
		}

		// Token: 0x0400C741 RID: 51009
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroInstigator";

		// Token: 0x0400C742 RID: 51010
		private static IntPtr _ScriptStructPtr;
	}
}
