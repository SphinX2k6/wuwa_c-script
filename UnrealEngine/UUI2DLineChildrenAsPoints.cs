using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200211A RID: 8474
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UI2DLineChildrenAsPoints")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2304)]
	public class UUI2DLineChildrenAsPoints : UUI2DLineRendererBase, IUnrealUObject, IUnrealObject, IUILayoutInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601FE1F RID: 130591 RVA: 0x002F6FBF File Offset: 0x002F51BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUI2DLineChildrenAsPoints._ClassPtr;
		}

		// Token: 0x0601FE20 RID: 130592 RVA: 0x002F6FCB File Offset: 0x002F51CB
		int IUILayoutInterface.InterfaceOffset()
		{
			return UUI2DLineChildrenAsPoints.__InterfaceOffset_IUILayoutInterface;
		}

		// Token: 0x0601FE21 RID: 130593 RVA: 0x002F6FD4 File Offset: 0x002F51D4
		public UUI2DLineChildrenAsPoints() : this(BuiltinUtils.AllocNativeUObject(UUI2DLineChildrenAsPoints.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE22 RID: 130594 RVA: 0x002F6FFC File Offset: 0x002F51FC
		public UUI2DLineChildrenAsPoints(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUI2DLineChildrenAsPoints.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D65 RID: 32101
		// (get) Token: 0x0601FE23 RID: 130595 RVA: 0x002F7030 File Offset: 0x002F5230
		// (set) Token: 0x0601FE24 RID: 130596 RVA: 0x002F7069 File Offset: 0x002F5269
		public TArray<FVector2D> CurrentPointArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._CurrentPointArray) == null)
				{
					result = (this._CurrentPointArray = new TArray<FVector2D>(base.NativePtr + (IntPtr)UUI2DLineChildrenAsPoints.__PropertyOffset_CurrentPointArray, this));
				}
				return result;
			}
			set
			{
				this.CurrentPointArray.CopyAssign(value);
			}
		}

		// Token: 0x17007D66 RID: 32102
		// (get) Token: 0x0601FE25 RID: 130597 RVA: 0x002F7078 File Offset: 0x002F5278
		// (set) Token: 0x0601FE26 RID: 130598 RVA: 0x002F70B1 File Offset: 0x002F52B1
		public TArray<UUIItem> SortedItemArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIItem> result;
				if ((result = this._SortedItemArray) == null)
				{
					result = (this._SortedItemArray = new TArray<UUIItem>(base.NativePtr + (IntPtr)UUI2DLineChildrenAsPoints.__PropertyOffset_SortedItemArray, this));
				}
				return result;
			}
			set
			{
				this.SortedItemArray.CopyAssign(value);
			}
		}

		// Token: 0x0601FE27 RID: 130599 RVA: 0x002F70BF File Offset: 0x002F52BF
		static UUI2DLineChildrenAsPoints()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineChildrenAsPoints");
		}

		// Token: 0x0601FE28 RID: 130600 RVA: 0x002F70CD File Offset: 0x002F52CD
		protected UUI2DLineChildrenAsPoints(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112DC RID: 70364
		internal static int __InterfaceOffset_IUILayoutInterface;

		// Token: 0x040112DD RID: 70365
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineChildrenAsPoints";

		// Token: 0x040112DE RID: 70366
		private static IntPtr _ClassPtr;

		// Token: 0x040112DF RID: 70367
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112E0 RID: 70368
		internal static int __PropertyOffset_CurrentPointArray;

		// Token: 0x040112E1 RID: 70369
		[Nullable(2)]
		private TArray<FVector2D> _CurrentPointArray;

		// Token: 0x040112E2 RID: 70370
		internal static int __PropertyOffset_SortedItemArray;

		// Token: 0x040112E3 RID: 70371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIItem> _SortedItemArray;
	}
}
