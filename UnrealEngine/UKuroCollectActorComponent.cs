using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D1 RID: 1489
	[UnrealObjectPath("/Script/KuroUtility.KuroCollectActorComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroCollectActorComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008409 RID: 33801 RVA: 0x000C41F6 File Offset: 0x000C23F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCollectActorComponent._ClassPtr;
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x000C4204 File Offset: 0x000C2404
		public UKuroCollectActorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCollectActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x000C422C File Offset: 0x000C242C
		[NullableContext(1)]
		public UKuroCollectActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCollectActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600840C RID: 33804 RVA: 0x000C425F File Offset: 0x000C245F
		// (set) Token: 0x0600840D RID: 33805 RVA: 0x000C426F File Offset: 0x000C246F
		public unsafe ECollectActorType CollectActorType
		{
			get
			{
				return (ECollectActorType)(*(base.NativePtr + (IntPtr)UKuroCollectActorComponent.__PropertyOffset_CollectActorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCollectActorComponent.__PropertyOffset_CollectActorType) = (byte)value;
			}
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x000C4280 File Offset: 0x000C2480
		public void RemoveCollectActorComponentInEditor()
		{
			UKuroCollectActorComponent.__RemoveCollectActorComponentInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x000C428D File Offset: 0x000C248D
		[NullableContext(2)]
		public static AActor GetActorWithTag(FName Tag, ECollectActorType Type)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroCollectActorComponent.__GetActorWithTag_Internal(Tag, Type));
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x000C429B File Offset: 0x000C249B
		public static void GetActorsWithTag(FName Tag, ECollectActorType Type, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutResult)
		{
			UKuroCollectActorComponent.__GetActorsWithTag_Internal(Tag, Type, (OutResult ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x000C42B4 File Offset: 0x000C24B4
		public void AddCollectActorComponentInEditor()
		{
			UKuroCollectActorComponent.__AddCollectActorComponentInEditor_Internal(base.NativePtr);
		}

		// Token: 0x06008412 RID: 33810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveCollectActorComponentInEditor_Internal(IntPtr @this);

		// Token: 0x06008413 RID: 33811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorWithTag_Internal(FName Tag, ECollectActorType Type);

		// Token: 0x06008414 RID: 33812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorsWithTag_Internal(FName Tag, ECollectActorType Type, IntPtr OutResult);

		// Token: 0x06008415 RID: 33813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCollectActorComponentInEditor_Internal(IntPtr @this);

		// Token: 0x06008416 RID: 33814 RVA: 0x000C42C1 File Offset: 0x000C24C1
		static UKuroCollectActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCollectActorComponent");
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x000C42CF File Offset: 0x000C24CF
		protected UKuroCollectActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039BE RID: 14782
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCollectActorComponent";

		// Token: 0x040039BF RID: 14783
		private static IntPtr _ClassPtr;

		// Token: 0x040039C0 RID: 14784
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039C1 RID: 14785
		internal static int __PropertyOffset_CollectActorType;
	}
}
