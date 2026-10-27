using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E8 RID: 232
	[UnrealObjectPath("/Script/AIModule.AIDataProviderStructValue")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAIDataProviderStructValue : FAIDataProviderValue, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600127F RID: 4735 RVA: 0x0001B76F File Offset: 0x0001996F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDataProviderStructValue._ScriptStructPtr != 0) ? FAIDataProviderStructValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDataProviderStructValue", ref FAIDataProviderStructValue._ScriptStructPtr);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0001B793 File Offset: 0x00019993
		public FAIDataProviderStructValue()
		{
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0001B79B File Offset: 0x0001999B
		[NullableContext(1)]
		public FAIDataProviderStructValue(UAIDataProvider DataBinding, FName DataField)
		{
			base.DataBinding = DataBinding;
			base.DataField = DataField;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0001B7B1 File Offset: 0x000199B1
		protected override IntPtr GetUStructPtr()
		{
			return FAIDataProviderStructValue.StaticStruct();
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0001B7BD File Offset: 0x000199BD
		[NullableContext(2)]
		public FAIDataProviderStructValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0001B7C7 File Offset: 0x000199C7
		public FAIDataProviderStructValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0001B7D2 File Offset: 0x000199D2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDataProviderStructValue(Pointer, false, true);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0001B7DC File Offset: 0x000199DC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDataProviderStructValue(Pointer, MemoryOwner);
		}

		// Token: 0x0400032C RID: 812
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProviderStructValue";

		// Token: 0x0400032D RID: 813
		private static IntPtr _ScriptStructPtr;
	}
}
