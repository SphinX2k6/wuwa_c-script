using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000942 RID: 2370
	[UnrealObjectPath("/Script/Engine.CollectionVectorParameter")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FCollectionVectorParameter : FCollectionParameterBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060085FB RID: 34299 RVA: 0x000BEF39 File Offset: 0x000BD139
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollectionVectorParameter._ScriptStructPtr != 0) ? FCollectionVectorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollectionVectorParameter", ref FCollectionVectorParameter._ScriptStructPtr);
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x060085FC RID: 34300 RVA: 0x000BEF5D File Offset: 0x000BD15D
		// (set) Token: 0x060085FD RID: 34301 RVA: 0x000BEF71 File Offset: 0x000BD171
		public unsafe FLinearColor DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollectionVectorParameter.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollectionVectorParameter.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x000BEF86 File Offset: 0x000BD186
		public FCollectionVectorParameter()
		{
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x000BEF8E File Offset: 0x000BD18E
		public FCollectionVectorParameter(FLinearColor DefaultValue, FName ParameterName, FGuid Id)
		{
			this.DefaultValue = DefaultValue;
			base.ParameterName = ParameterName;
			base.Id = Id;
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x000BEFAB File Offset: 0x000BD1AB
		protected override IntPtr GetUStructPtr()
		{
			return FCollectionVectorParameter.StaticStruct();
		}

		// Token: 0x06008601 RID: 34305 RVA: 0x000BEFB7 File Offset: 0x000BD1B7
		[NullableContext(2)]
		public FCollectionVectorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x000BEFC1 File Offset: 0x000BD1C1
		public FCollectionVectorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008603 RID: 34307 RVA: 0x000BEFCC File Offset: 0x000BD1CC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollectionVectorParameter(Pointer, false, true);
		}

		// Token: 0x06008604 RID: 34308 RVA: 0x000BEFD6 File Offset: 0x000BD1D6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollectionVectorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04003FBC RID: 16316
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CollectionVectorParameter";

		// Token: 0x04003FBD RID: 16317
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FBE RID: 16318
		internal static int __PropertyOffset_DefaultValue;
	}
}
