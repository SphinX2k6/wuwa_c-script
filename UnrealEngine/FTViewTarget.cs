using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A8 RID: 680
	[UnrealObjectPath("/Script/Engine.TViewTarget")]
	[UnrealStructLayout(2816, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2816)]
	public class FTViewTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A10 RID: 18960 RVA: 0x00067BFA File Offset: 0x00065DFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTViewTarget._ScriptStructPtr != 0) ? FTViewTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TViewTarget", ref FTViewTarget._ScriptStructPtr);
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x00067C1E File Offset: 0x00065E1E
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x00067C32 File Offset: 0x00065E32
		[Nullable(2)]
		public unsafe AActor Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FTViewTarget.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTViewTarget.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00067C47 File Offset: 0x00065E47
		public FTViewTarget()
		{
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x00067C4F File Offset: 0x00065E4F
		protected override IntPtr GetUStructPtr()
		{
			return FTViewTarget.StaticStruct();
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00067C5B File Offset: 0x00065E5B
		[NullableContext(2)]
		public FTViewTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x00067C65 File Offset: 0x00065E65
		public FTViewTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x00067C70 File Offset: 0x00065E70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTViewTarget(Pointer, false, true);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00067C7A File Offset: 0x00065E7A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTViewTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04001D27 RID: 7463
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TViewTarget";

		// Token: 0x04001D28 RID: 7464
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D29 RID: 7465
		internal static int __PropertyOffset_Target;
	}
}
