using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000941 RID: 2369
	[UnrealObjectPath("/Script/Engine.CollectionScalarParameter")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCollectionScalarParameter : FCollectionParameterBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060085F1 RID: 34289 RVA: 0x000BEE9B File Offset: 0x000BD09B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollectionScalarParameter._ScriptStructPtr != 0) ? FCollectionScalarParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollectionScalarParameter", ref FCollectionScalarParameter._ScriptStructPtr);
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x060085F2 RID: 34290 RVA: 0x000BEEBF File Offset: 0x000BD0BF
		// (set) Token: 0x060085F3 RID: 34291 RVA: 0x000BEECF File Offset: 0x000BD0CF
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollectionScalarParameter.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollectionScalarParameter.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x060085F4 RID: 34292 RVA: 0x000BEEE0 File Offset: 0x000BD0E0
		public FCollectionScalarParameter()
		{
		}

		// Token: 0x060085F5 RID: 34293 RVA: 0x000BEEE8 File Offset: 0x000BD0E8
		public FCollectionScalarParameter(float DefaultValue, FName ParameterName, FGuid Id)
		{
			this.DefaultValue = DefaultValue;
			base.ParameterName = ParameterName;
			base.Id = Id;
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x000BEF05 File Offset: 0x000BD105
		protected override IntPtr GetUStructPtr()
		{
			return FCollectionScalarParameter.StaticStruct();
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x000BEF11 File Offset: 0x000BD111
		[NullableContext(2)]
		public FCollectionScalarParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x000BEF1B File Offset: 0x000BD11B
		public FCollectionScalarParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x000BEF26 File Offset: 0x000BD126
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollectionScalarParameter(Pointer, false, true);
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x000BEF30 File Offset: 0x000BD130
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollectionScalarParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04003FB9 RID: 16313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CollectionScalarParameter";

		// Token: 0x04003FBA RID: 16314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FBB RID: 16315
		internal static int __PropertyOffset_DefaultValue;
	}
}
