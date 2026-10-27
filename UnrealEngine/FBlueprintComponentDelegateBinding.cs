using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008BB RID: 2235
	[UnrealObjectPath("/Script/Engine.BlueprintComponentDelegateBinding")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FBlueprintComponentDelegateBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A21 RID: 31265 RVA: 0x000AEB23 File Offset: 0x000ACD23
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintComponentDelegateBinding._ScriptStructPtr != 0) ? FBlueprintComponentDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintComponentDelegateBinding", ref FBlueprintComponentDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x000AEB47 File Offset: 0x000ACD47
		// (set) Token: 0x06007A23 RID: 31267 RVA: 0x000AEB5B File Offset: 0x000ACD5B
		public unsafe FName ComponentPropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintComponentDelegateBinding.__PropertyOffset_ComponentPropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintComponentDelegateBinding.__PropertyOffset_ComponentPropertyName) = value;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06007A24 RID: 31268 RVA: 0x000AEB70 File Offset: 0x000ACD70
		// (set) Token: 0x06007A25 RID: 31269 RVA: 0x000AEB84 File Offset: 0x000ACD84
		public unsafe FName DelegatePropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintComponentDelegateBinding.__PropertyOffset_DelegatePropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintComponentDelegateBinding.__PropertyOffset_DelegatePropertyName) = value;
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06007A26 RID: 31270 RVA: 0x000AEB99 File Offset: 0x000ACD99
		// (set) Token: 0x06007A27 RID: 31271 RVA: 0x000AEBAD File Offset: 0x000ACDAD
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintComponentDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintComponentDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x000AEBC2 File Offset: 0x000ACDC2
		public FBlueprintComponentDelegateBinding()
		{
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x000AEBCA File Offset: 0x000ACDCA
		public FBlueprintComponentDelegateBinding(FName ComponentPropertyName, FName DelegatePropertyName, FName FunctionNameToBind)
		{
			this.ComponentPropertyName = ComponentPropertyName;
			this.DelegatePropertyName = DelegatePropertyName;
			this.FunctionNameToBind = FunctionNameToBind;
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x000AEBE7 File Offset: 0x000ACDE7
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintComponentDelegateBinding.StaticStruct();
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x000AEBF3 File Offset: 0x000ACDF3
		[NullableContext(2)]
		public FBlueprintComponentDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x000AEBFD File Offset: 0x000ACDFD
		public FBlueprintComponentDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x000AEC08 File Offset: 0x000ACE08
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintComponentDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x000AEC12 File Offset: 0x000ACE12
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintComponentDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003AB9 RID: 15033
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlueprintComponentDelegateBinding";

		// Token: 0x04003ABA RID: 15034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003ABB RID: 15035
		internal static int __PropertyOffset_ComponentPropertyName;

		// Token: 0x04003ABC RID: 15036
		internal static int __PropertyOffset_DelegatePropertyName;

		// Token: 0x04003ABD RID: 15037
		internal static int __PropertyOffset_FunctionNameToBind;
	}
}
