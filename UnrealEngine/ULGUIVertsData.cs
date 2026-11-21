using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CA RID: 1738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIVertsData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class ULGUIVertsData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600943F RID: 37951 RVA: 0x000DFB12 File Offset: 0x000DDD12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIVertsData._ClassPtr;
		}

		// Token: 0x06009440 RID: 37952 RVA: 0x000DFB20 File Offset: 0x000DDD20
		public ULGUIVertsData() : this(BuiltinUtils.AllocNativeUObject(ULGUIVertsData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x000DFB48 File Offset: 0x000DDD48
		public ULGUIVertsData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIVertsData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x000DFB7C File Offset: 0x000DDD7C
		// (set) Token: 0x06009443 RID: 37955 RVA: 0x000DFBB5 File Offset: 0x000DDDB5
		public TArray<FVector2D> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVector2D>(base.NativePtr + (IntPtr)ULGUIVertsData.__PropertyOffset_Points, this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06009444 RID: 37956 RVA: 0x000DFBC3 File Offset: 0x000DDDC3
		// (set) Token: 0x06009445 RID: 37957 RVA: 0x000DFBD7 File Offset: 0x000DDDD7
		[Nullable(2)]
		public unsafe UObject SourceAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIVertsData.__PropertyOffset_SourceAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIVertsData.__PropertyOffset_SourceAsset, value);
			}
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x000DFBEC File Offset: 0x000DDDEC
		public TSoftObjectPtr<UObject> GetSourceAsset()
		{
			return new TSoftObjectPtr<UObject>(ULGUIVertsData.__GetSourceAsset_Internal(base.NativePtr), true, true);
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x000DFC00 File Offset: 0x000DDE00
		public TArray<FVector2D> GetPoints()
		{
			return new TArray<FVector2D>(ULGUIVertsData.__GetPoints_Internal(base.NativePtr), null);
		}

		// Token: 0x06009448 RID: 37960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSourceAsset_Internal(IntPtr @this);

		// Token: 0x06009449 RID: 37961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPoints_Internal(IntPtr @this);

		// Token: 0x0600944A RID: 37962 RVA: 0x000DFC13 File Offset: 0x000DDE13
		static ULGUIVertsData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIVertsData");
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x000DFC21 File Offset: 0x000DDE21
		protected ULGUIVertsData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004093 RID: 16531
		public new const string __ObjectPath = "/Script/LGUI.LGUIVertsData";

		// Token: 0x04004094 RID: 16532
		private static IntPtr _ClassPtr;

		// Token: 0x04004095 RID: 16533
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004096 RID: 16534
		internal static int __PropertyOffset_Points;

		// Token: 0x04004097 RID: 16535
		[Nullable(2)]
		private TArray<FVector2D> _Points;

		// Token: 0x04004098 RID: 16536
		internal static int __PropertyOffset_SourceAsset;
	}
}
