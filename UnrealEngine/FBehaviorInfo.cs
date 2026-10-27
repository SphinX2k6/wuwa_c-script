using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001539 RID: 5433
	[UnrealObjectPath("/Script/InteractiveToolsFramework.BehaviorInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBehaviorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013BA4 RID: 80804 RVA: 0x001CF914 File Offset: 0x001CDB14
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBehaviorInfo._ScriptStructPtr != 0) ? FBehaviorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InteractiveToolsFramework.BehaviorInfo", ref FBehaviorInfo._ScriptStructPtr);
		}

		// Token: 0x17004D44 RID: 19780
		// (get) Token: 0x06013BA5 RID: 80805 RVA: 0x001CF938 File Offset: 0x001CDB38
		// (set) Token: 0x06013BA6 RID: 80806 RVA: 0x001CF94C File Offset: 0x001CDB4C
		[Nullable(2)]
		public unsafe UInputBehavior Behavior
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputBehavior>(base.NativePtr / (IntPtr)sizeof(void*) + FBehaviorInfo.__PropertyOffset_Behavior);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBehaviorInfo.__PropertyOffset_Behavior, value);
			}
		}

		// Token: 0x06013BA7 RID: 80807 RVA: 0x001CF961 File Offset: 0x001CDB61
		public FBehaviorInfo()
		{
		}

		// Token: 0x06013BA8 RID: 80808 RVA: 0x001CF969 File Offset: 0x001CDB69
		[NullableContext(1)]
		public FBehaviorInfo(UInputBehavior Behavior)
		{
			this.Behavior = Behavior;
		}

		// Token: 0x06013BA9 RID: 80809 RVA: 0x001CF978 File Offset: 0x001CDB78
		protected override IntPtr GetUStructPtr()
		{
			return FBehaviorInfo.StaticStruct();
		}

		// Token: 0x06013BAA RID: 80810 RVA: 0x001CF984 File Offset: 0x001CDB84
		[NullableContext(2)]
		public FBehaviorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013BAB RID: 80811 RVA: 0x001CF98E File Offset: 0x001CDB8E
		public FBehaviorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013BAC RID: 80812 RVA: 0x001CF999 File Offset: 0x001CDB99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBehaviorInfo(Pointer, false, true);
		}

		// Token: 0x06013BAD RID: 80813 RVA: 0x001CF9A3 File Offset: 0x001CDBA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBehaviorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400AABF RID: 43711
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.BehaviorInfo";

		// Token: 0x0400AAC0 RID: 43712
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AAC1 RID: 43713
		internal static int __PropertyOffset_Behavior;
	}
}
