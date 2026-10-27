using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020DE RID: 8414
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIVertsData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class ULGUIVertsData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAEB RID: 129771 RVA: 0x002F1FF0 File Offset: 0x002F01F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIVertsData._ClassPtr;
		}

		// Token: 0x0601FAEC RID: 129772 RVA: 0x002F1FFC File Offset: 0x002F01FC
		public ULGUIVertsData() : this(BuiltinUtils.AllocNativeUObject(ULGUIVertsData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAED RID: 129773 RVA: 0x002F2024 File Offset: 0x002F0224
		public ULGUIVertsData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIVertsData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CDC RID: 31964
		// (get) Token: 0x0601FAEE RID: 129774 RVA: 0x002F2058 File Offset: 0x002F0258
		// (set) Token: 0x0601FAEF RID: 129775 RVA: 0x002F2091 File Offset: 0x002F0291
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

		// Token: 0x17007CDD RID: 31965
		// (get) Token: 0x0601FAF0 RID: 129776 RVA: 0x002F209F File Offset: 0x002F029F
		// (set) Token: 0x0601FAF1 RID: 129777 RVA: 0x002F20B3 File Offset: 0x002F02B3
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

		// Token: 0x0601FAF2 RID: 129778 RVA: 0x002F20C8 File Offset: 0x002F02C8
		public TSoftObjectPtr<UObject> GetSourceAsset()
		{
			return new TSoftObjectPtr<UObject>(ULGUIVertsData.__GetSourceAsset_Internal(base.NativePtr), true, true);
		}

		// Token: 0x0601FAF3 RID: 129779 RVA: 0x002F20DC File Offset: 0x002F02DC
		public TArray<FVector2D> GetPoints()
		{
			return new TArray<FVector2D>(ULGUIVertsData.__GetPoints_Internal(base.NativePtr), null);
		}

		// Token: 0x0601FAF4 RID: 129780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSourceAsset_Internal(IntPtr @this);

		// Token: 0x0601FAF5 RID: 129781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPoints_Internal(IntPtr @this);

		// Token: 0x0601FAF6 RID: 129782 RVA: 0x002F20EF File Offset: 0x002F02EF
		static ULGUIVertsData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIVertsData");
		}

		// Token: 0x0601FAF7 RID: 129783 RVA: 0x002F20FD File Offset: 0x002F02FD
		protected ULGUIVertsData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401117C RID: 70012
		public new const string __ObjectPath = "/Script/LGUI.LGUIVertsData";

		// Token: 0x0401117D RID: 70013
		private static IntPtr _ClassPtr;

		// Token: 0x0401117E RID: 70014
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401117F RID: 70015
		internal static int __PropertyOffset_Points;

		// Token: 0x04011180 RID: 70016
		[Nullable(2)]
		private TArray<FVector2D> _Points;

		// Token: 0x04011181 RID: 70017
		internal static int __PropertyOffset_SourceAsset;
	}
}
