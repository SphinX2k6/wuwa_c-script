using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000940 RID: 2368
	[UnrealObjectPath("/Script/Engine.CollectionReference")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCollectionReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060085E7 RID: 34279 RVA: 0x000BEE03 File Offset: 0x000BD003
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollectionReference._ScriptStructPtr != 0) ? FCollectionReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollectionReference", ref FCollectionReference._ScriptStructPtr);
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x060085E8 RID: 34280 RVA: 0x000BEE27 File Offset: 0x000BD027
		// (set) Token: 0x060085E9 RID: 34281 RVA: 0x000BEE3B File Offset: 0x000BD03B
		public unsafe FName CollectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollectionReference.__PropertyOffset_CollectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollectionReference.__PropertyOffset_CollectionName) = value;
			}
		}

		// Token: 0x060085EA RID: 34282 RVA: 0x000BEE50 File Offset: 0x000BD050
		public FCollectionReference()
		{
		}

		// Token: 0x060085EB RID: 34283 RVA: 0x000BEE58 File Offset: 0x000BD058
		public FCollectionReference(FName CollectionName)
		{
			this.CollectionName = CollectionName;
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x000BEE67 File Offset: 0x000BD067
		protected override IntPtr GetUStructPtr()
		{
			return FCollectionReference.StaticStruct();
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x000BEE73 File Offset: 0x000BD073
		[NullableContext(2)]
		public FCollectionReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x000BEE7D File Offset: 0x000BD07D
		public FCollectionReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x000BEE88 File Offset: 0x000BD088
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollectionReference(Pointer, false, true);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x000BEE92 File Offset: 0x000BD092
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollectionReference(Pointer, MemoryOwner);
		}

		// Token: 0x04003FB6 RID: 16310
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollectionReference";

		// Token: 0x04003FB7 RID: 16311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FB8 RID: 16312
		internal static int __PropertyOffset_CollectionName;
	}
}
