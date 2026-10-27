using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000972 RID: 2418
	[UnrealObjectPath("/Script/Engine.ConstraintInstanceBase")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FConstraintInstanceBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600888F RID: 34959 RVA: 0x000C3A88 File Offset: 0x000C1C88
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintInstanceBase._ScriptStructPtr != 0) ? FConstraintInstanceBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConstraintInstanceBase", ref FConstraintInstanceBase._ScriptStructPtr);
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x000C3AAC File Offset: 0x000C1CAC
		public FConstraintInstanceBase()
		{
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x000C3AB4 File Offset: 0x000C1CB4
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintInstanceBase.StaticStruct();
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x000C3AC0 File Offset: 0x000C1CC0
		[NullableContext(2)]
		public FConstraintInstanceBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x000C3ACA File Offset: 0x000C1CCA
		public FConstraintInstanceBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x000C3AD5 File Offset: 0x000C1CD5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintInstanceBase(Pointer, false, true);
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x000C3ADF File Offset: 0x000C1CDF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintInstanceBase(Pointer, MemoryOwner);
		}

		// Token: 0x040040EA RID: 16618
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ConstraintInstanceBase";

		// Token: 0x040040EB RID: 16619
		private static IntPtr _ScriptStructPtr;
	}
}
