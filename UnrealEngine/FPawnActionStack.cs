using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D7 RID: 471
	[UnrealObjectPath("/Script/AIModule.PawnActionStack")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FPawnActionStack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001BD1 RID: 7121 RVA: 0x00029781 File Offset: 0x00027981
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPawnActionStack._ScriptStructPtr != 0) ? FPawnActionStack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.PawnActionStack", ref FPawnActionStack._ScriptStructPtr);
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000297A5 File Offset: 0x000279A5
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x000297B9 File Offset: 0x000279B9
		[Nullable(2)]
		public unsafe UPawnAction TopAction
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + FPawnActionStack.__PropertyOffset_TopAction);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPawnActionStack.__PropertyOffset_TopAction, value);
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000297CE File Offset: 0x000279CE
		public FPawnActionStack()
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000297D6 File Offset: 0x000279D6
		[NullableContext(1)]
		public FPawnActionStack(UPawnAction TopAction)
		{
			this.TopAction = TopAction;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x000297E5 File Offset: 0x000279E5
		protected override IntPtr GetUStructPtr()
		{
			return FPawnActionStack.StaticStruct();
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x000297F1 File Offset: 0x000279F1
		[NullableContext(2)]
		public FPawnActionStack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000297FB File Offset: 0x000279FB
		public FPawnActionStack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00029806 File Offset: 0x00027A06
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPawnActionStack(Pointer, false, true);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00029810 File Offset: 0x00027A10
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPawnActionStack(Pointer, MemoryOwner);
		}

		// Token: 0x040008F4 RID: 2292
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.PawnActionStack";

		// Token: 0x040008F5 RID: 2293
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040008F6 RID: 2294
		internal static int __PropertyOffset_TopAction;
	}
}
