using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001429 RID: 5161
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionCache")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UGeometryCollectionCache : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012D81 RID: 77185 RVA: 0x001BB629 File Offset: 0x001B9829
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCollectionCache._ClassPtr;
		}

		// Token: 0x06012D82 RID: 77186 RVA: 0x001BB638 File Offset: 0x001B9838
		public UGeometryCollectionCache() : this(BuiltinUtils.AllocNativeUObject(UGeometryCollectionCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012D83 RID: 77187 RVA: 0x001BB660 File Offset: 0x001B9860
		public UGeometryCollectionCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCollectionCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x06012D84 RID: 77188 RVA: 0x001BB694 File Offset: 0x001B9894
		// (set) Token: 0x06012D85 RID: 77189 RVA: 0x001BB6CD File Offset: 0x001B98CD
		public FRecordedTransformTrack RecordedData
		{
			get
			{
				base.FastCheckIsValid();
				FRecordedTransformTrack result;
				if ((result = this._RecordedData) == null)
				{
					result = (this._RecordedData = new FRecordedTransformTrack(base.NativePtr + (IntPtr)UGeometryCollectionCache.__PropertyOffset_RecordedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRecordedTransformTrack.StaticStruct(), base.NativePtr + (IntPtr)UGeometryCollectionCache.__PropertyOffset_RecordedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x06012D86 RID: 77190 RVA: 0x001BB6EE File Offset: 0x001B98EE
		// (set) Token: 0x06012D87 RID: 77191 RVA: 0x001BB702 File Offset: 0x001B9902
		[Nullable(2)]
		public unsafe UGeometryCollection SupportedCollection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionCache.__PropertyOffset_SupportedCollection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCollectionCache.__PropertyOffset_SupportedCollection, value);
			}
		}

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x06012D88 RID: 77192 RVA: 0x001BB717 File Offset: 0x001B9917
		// (set) Token: 0x06012D89 RID: 77193 RVA: 0x001BB72B File Offset: 0x001B992B
		public unsafe FGuid CompatibleCollectionState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollectionCache.__PropertyOffset_CompatibleCollectionState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollectionCache.__PropertyOffset_CompatibleCollectionState) = value;
			}
		}

		// Token: 0x06012D8A RID: 77194 RVA: 0x001BB740 File Offset: 0x001B9940
		static UGeometryCollectionCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollectionCache");
		}

		// Token: 0x06012D8B RID: 77195 RVA: 0x001BB74E File Offset: 0x001B994E
		protected UGeometryCollectionCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A11E RID: 41246
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionCache";

		// Token: 0x0400A11F RID: 41247
		private static IntPtr _ClassPtr;

		// Token: 0x0400A120 RID: 41248
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A121 RID: 41249
		internal static int __PropertyOffset_RecordedData;

		// Token: 0x0400A122 RID: 41250
		[Nullable(2)]
		private FRecordedTransformTrack _RecordedData;

		// Token: 0x0400A123 RID: 41251
		internal static int __PropertyOffset_SupportedCollection;

		// Token: 0x0400A124 RID: 41252
		internal static int __PropertyOffset_CompatibleCollectionState;
	}
}
