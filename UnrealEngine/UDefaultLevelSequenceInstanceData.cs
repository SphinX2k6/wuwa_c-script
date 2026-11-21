using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200063E RID: 1598
	[UnrealObjectPath("/Script/LevelSequence.DefaultLevelSequenceInstanceData")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UDefaultLevelSequenceInstanceData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C92 RID: 35986 RVA: 0x000D395D File Offset: 0x000D1B5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDefaultLevelSequenceInstanceData._ClassPtr;
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x000D396C File Offset: 0x000D1B6C
		public UDefaultLevelSequenceInstanceData() : this(BuiltinUtils.AllocNativeUObject(UDefaultLevelSequenceInstanceData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x000D3994 File Offset: 0x000D1B94
		[NullableContext(1)]
		public UDefaultLevelSequenceInstanceData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDefaultLevelSequenceInstanceData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06008C95 RID: 35989 RVA: 0x000D39C7 File Offset: 0x000D1BC7
		// (set) Token: 0x06008C96 RID: 35990 RVA: 0x000D39DB File Offset: 0x000D1BDB
		[Nullable(2)]
		public unsafe AActor TransformOriginActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOriginActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOriginActor, value);
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06008C97 RID: 35991 RVA: 0x000D39F0 File Offset: 0x000D1BF0
		// (set) Token: 0x06008C98 RID: 35992 RVA: 0x000D3A04 File Offset: 0x000D1C04
		public unsafe FTransform TransformOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_TransformOrigin) = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06008C99 RID: 35993 RVA: 0x000D3A19 File Offset: 0x000D1C19
		// (set) Token: 0x06008C9A RID: 35994 RVA: 0x000D3A29 File Offset: 0x000D1C29
		public unsafe bool ApplyWorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_ApplyWorldOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDefaultLevelSequenceInstanceData.__PropertyOffset_ApplyWorldOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x000D3A3A File Offset: 0x000D1C3A
		static UDefaultLevelSequenceInstanceData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.DefaultLevelSequenceInstanceData");
		}

		// Token: 0x06008C9C RID: 35996 RVA: 0x000D3A48 File Offset: 0x000D1C48
		protected UDefaultLevelSequenceInstanceData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D3C RID: 15676
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.DefaultLevelSequenceInstanceData";

		// Token: 0x04003D3D RID: 15677
		private static IntPtr _ClassPtr;

		// Token: 0x04003D3E RID: 15678
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D3F RID: 15679
		internal static int __PropertyOffset_TransformOriginActor;

		// Token: 0x04003D40 RID: 15680
		internal static int __PropertyOffset_TransformOrigin;

		// Token: 0x04003D41 RID: 15681
		internal static int __PropertyOffset_ApplyWorldOrigin;
	}
}
