using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E9 RID: 233
	[UnrealObjectPath("/Script/AIModule.AIDataProviderTypedValue")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAIDataProviderTypedValue : FAIDataProviderValue, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x0001B7E5 File Offset: 0x000199E5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDataProviderTypedValue._ScriptStructPtr != 0) ? FAIDataProviderTypedValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDataProviderTypedValue", ref FAIDataProviderTypedValue._ScriptStructPtr);
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0001B809 File Offset: 0x00019A09
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x0001B81D File Offset: 0x00019A1D
		public unsafe UClassStackOnlyPtr PropertyType_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDataProviderTypedValue.__PropertyOffset_PropertyType_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDataProviderTypedValue.__PropertyOffset_PropertyType_DEPRECATED) = value;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0001B832 File Offset: 0x00019A32
		public FAIDataProviderTypedValue()
		{
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0001B83A File Offset: 0x00019A3A
		[NullableContext(1)]
		public FAIDataProviderTypedValue(UClassStackOnlyPtr PropertyType_DEPRECATED, UAIDataProvider DataBinding, FName DataField)
		{
			this.PropertyType_DEPRECATED = PropertyType_DEPRECATED;
			base.DataBinding = DataBinding;
			base.DataField = DataField;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0001B857 File Offset: 0x00019A57
		protected override IntPtr GetUStructPtr()
		{
			return FAIDataProviderTypedValue.StaticStruct();
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0001B863 File Offset: 0x00019A63
		[NullableContext(2)]
		public FAIDataProviderTypedValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0001B86D File Offset: 0x00019A6D
		public FAIDataProviderTypedValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0001B878 File Offset: 0x00019A78
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDataProviderTypedValue(Pointer, false, true);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0001B882 File Offset: 0x00019A82
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDataProviderTypedValue(Pointer, MemoryOwner);
		}

		// Token: 0x0400032E RID: 814
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProviderTypedValue";

		// Token: 0x0400032F RID: 815
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000330 RID: 816
		internal static int __PropertyOffset_PropertyType_DEPRECATED;
	}
}
