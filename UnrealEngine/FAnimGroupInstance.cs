using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000809 RID: 2057
	[UnrealObjectPath("/Script/Engine.AnimGroupInstance")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FAnimGroupInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D97 RID: 28055 RVA: 0x0009DAD7 File Offset: 0x0009BCD7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimGroupInstance._ScriptStructPtr != 0) ? FAnimGroupInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimGroupInstance", ref FAnimGroupInstance._ScriptStructPtr);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x0009DAFB File Offset: 0x0009BCFB
		public FAnimGroupInstance()
		{
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x0009DB03 File Offset: 0x0009BD03
		protected override IntPtr GetUStructPtr()
		{
			return FAnimGroupInstance.StaticStruct();
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x0009DB0F File Offset: 0x0009BD0F
		[NullableContext(2)]
		public FAnimGroupInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x0009DB19 File Offset: 0x0009BD19
		public FAnimGroupInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x0009DB24 File Offset: 0x0009BD24
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimGroupInstance(Pointer, false, true);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x0009DB2E File Offset: 0x0009BD2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimGroupInstance(Pointer, MemoryOwner);
		}

		// Token: 0x040034EC RID: 13548
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimGroupInstance";

		// Token: 0x040034ED RID: 13549
		private static IntPtr _ScriptStructPtr;
	}
}
