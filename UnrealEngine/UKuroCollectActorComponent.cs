using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB2 RID: 7858
	[UnrealObjectPath("/Script/KuroUtility.KuroCollectActorComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroCollectActorComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD35 RID: 122165 RVA: 0x002C1F26 File Offset: 0x002C0126
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCollectActorComponent._ClassPtr;
		}

		// Token: 0x0601DD36 RID: 122166 RVA: 0x002C1F34 File Offset: 0x002C0134
		public UKuroCollectActorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCollectActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD37 RID: 122167 RVA: 0x002C1F5C File Offset: 0x002C015C
		[NullableContext(1)]
		public UKuroCollectActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCollectActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700779B RID: 30619
		// (get) Token: 0x0601DD38 RID: 122168 RVA: 0x002C1F8F File Offset: 0x002C018F
		// (set) Token: 0x0601DD39 RID: 122169 RVA: 0x002C1F9F File Offset: 0x002C019F
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

		// Token: 0x0601DD3A RID: 122170 RVA: 0x002C1FB0 File Offset: 0x002C01B0
		public void RemoveCollectActorComponentInEditor()
		{
			UKuroCollectActorComponent.__RemoveCollectActorComponentInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0601DD3B RID: 122171 RVA: 0x002C1FBD File Offset: 0x002C01BD
		[NullableContext(2)]
		public static AActor GetActorWithTag(FName Tag, ECollectActorType Type)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroCollectActorComponent.__GetActorWithTag_Internal(Tag, Type));
		}

		// Token: 0x0601DD3C RID: 122172 RVA: 0x002C1FCB File Offset: 0x002C01CB
		public static void GetActorsWithTag(FName Tag, ECollectActorType Type, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutResult)
		{
			UKuroCollectActorComponent.__GetActorsWithTag_Internal(Tag, Type, (OutResult ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0601DD3D RID: 122173 RVA: 0x002C1FE4 File Offset: 0x002C01E4
		public void AddCollectActorComponentInEditor()
		{
			UKuroCollectActorComponent.__AddCollectActorComponentInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0601DD3E RID: 122174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveCollectActorComponentInEditor_Internal(IntPtr @this);

		// Token: 0x0601DD3F RID: 122175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorWithTag_Internal(FName Tag, ECollectActorType Type);

		// Token: 0x0601DD40 RID: 122176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorsWithTag_Internal(FName Tag, ECollectActorType Type, IntPtr OutResult);

		// Token: 0x0601DD41 RID: 122177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCollectActorComponentInEditor_Internal(IntPtr @this);

		// Token: 0x0601DD42 RID: 122178 RVA: 0x002C1FF1 File Offset: 0x002C01F1
		static UKuroCollectActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCollectActorComponent");
		}

		// Token: 0x0601DD43 RID: 122179 RVA: 0x002C1FFF File Offset: 0x002C01FF
		protected UKuroCollectActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102A3 RID: 66211
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCollectActorComponent";

		// Token: 0x040102A4 RID: 66212
		private static IntPtr _ClassPtr;

		// Token: 0x040102A5 RID: 66213
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102A6 RID: 66214
		internal static int __PropertyOffset_CollectActorType;
	}
}
