using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008F5 RID: 2293
	[UnrealObjectPath("/Script/Engine.Brush")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ABrush : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DCB RID: 32203 RVA: 0x000B43E2 File Offset: 0x000B25E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABrush._ClassPtr;
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x000B43F0 File Offset: 0x000B25F0
		public ABrush() : this(BuiltinUtils.AllocNativeUObject(ABrush.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x000B4418 File Offset: 0x000B2618
		[NullableContext(1)]
		public ABrush(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABrush.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06007DCE RID: 32206 RVA: 0x000B444B File Offset: 0x000B264B
		// (set) Token: 0x06007DCF RID: 32207 RVA: 0x000B445F File Offset: 0x000B265F
		public unsafe TEnumAsByte<EBrushType> BrushType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_BrushType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_BrushType) = value;
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x000B4474 File Offset: 0x000B2674
		// (set) Token: 0x06007DD1 RID: 32209 RVA: 0x000B4488 File Offset: 0x000B2688
		public unsafe FColor BrushColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_BrushColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_BrushColor) = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06007DD2 RID: 32210 RVA: 0x000B449D File Offset: 0x000B269D
		// (set) Token: 0x06007DD3 RID: 32211 RVA: 0x000B44AD File Offset: 0x000B26AD
		public unsafe int PolyFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_PolyFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_PolyFlags) = value;
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06007DD4 RID: 32212 RVA: 0x000B44BE File Offset: 0x000B26BE
		// (set) Token: 0x06007DD5 RID: 32213 RVA: 0x000B44D7 File Offset: 0x000B26D7
		public unsafe bool bColored
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bColored) & ABrush.__PropertyMask_bColored) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ABrush.__PropertyOffset_bColored) = ((*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bColored) & ~ABrush.__PropertyMask_bColored) | (value ? ABrush.__PropertyMask_bColored : 0));
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x000B4507 File Offset: 0x000B2707
		// (set) Token: 0x06007DD7 RID: 32215 RVA: 0x000B4520 File Offset: 0x000B2720
		public unsafe bool bSolidWhenSelected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bSolidWhenSelected) & ABrush.__PropertyMask_bSolidWhenSelected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ABrush.__PropertyOffset_bSolidWhenSelected) = ((*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bSolidWhenSelected) & ~ABrush.__PropertyMask_bSolidWhenSelected) | (value ? ABrush.__PropertyMask_bSolidWhenSelected : 0));
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x000B4550 File Offset: 0x000B2750
		// (set) Token: 0x06007DD9 RID: 32217 RVA: 0x000B4569 File Offset: 0x000B2769
		public unsafe bool bPlaceableFromClassBrowser
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bPlaceableFromClassBrowser) & ABrush.__PropertyMask_bPlaceableFromClassBrowser) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ABrush.__PropertyOffset_bPlaceableFromClassBrowser) = ((*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bPlaceableFromClassBrowser) & ~ABrush.__PropertyMask_bPlaceableFromClassBrowser) | (value ? ABrush.__PropertyMask_bPlaceableFromClassBrowser : 0));
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06007DDA RID: 32218 RVA: 0x000B4599 File Offset: 0x000B2799
		// (set) Token: 0x06007DDB RID: 32219 RVA: 0x000B45B2 File Offset: 0x000B27B2
		public unsafe bool bNotForClientOrServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bNotForClientOrServer) & ABrush.__PropertyMask_bNotForClientOrServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ABrush.__PropertyOffset_bNotForClientOrServer) = ((*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bNotForClientOrServer) & ~ABrush.__PropertyMask_bNotForClientOrServer) | (value ? ABrush.__PropertyMask_bNotForClientOrServer : 0));
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06007DDC RID: 32220 RVA: 0x000B45E2 File Offset: 0x000B27E2
		// (set) Token: 0x06007DDD RID: 32221 RVA: 0x000B45F6 File Offset: 0x000B27F6
		[Nullable(2)]
		public unsafe UModel Brush
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UModel>(base.NativePtr / (IntPtr)sizeof(void*) + ABrush.__PropertyOffset_Brush);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABrush.__PropertyOffset_Brush, value);
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06007DDE RID: 32222 RVA: 0x000B460B File Offset: 0x000B280B
		// (set) Token: 0x06007DDF RID: 32223 RVA: 0x000B461F File Offset: 0x000B281F
		[Nullable(2)]
		public unsafe UBrushComponent BrushComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBrushComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABrush.__PropertyOffset_BrushComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABrush.__PropertyOffset_BrushComponent, value);
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06007DE0 RID: 32224 RVA: 0x000B4634 File Offset: 0x000B2834
		// (set) Token: 0x06007DE1 RID: 32225 RVA: 0x000B464D File Offset: 0x000B284D
		public unsafe bool bInManipulation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bInManipulation) & ABrush.__PropertyMask_bInManipulation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ABrush.__PropertyOffset_bInManipulation) = ((*(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_bInManipulation) & ~ABrush.__PropertyMask_bInManipulation) | (value ? ABrush.__PropertyMask_bInManipulation : 0));
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06007DE2 RID: 32226 RVA: 0x000B4680 File Offset: 0x000B2880
		// (set) Token: 0x06007DE3 RID: 32227 RVA: 0x000B46B9 File Offset: 0x000B28B9
		[Nullable(1)]
		public TArray<FGeomSelection> SavedSelections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FGeomSelection> result;
				if ((result = this._SavedSelections) == null)
				{
					result = (this._SavedSelections = new TArray<FGeomSelection>(base.NativePtr + (IntPtr)ABrush.__PropertyOffset_SavedSelections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SavedSelections.CopyAssign(value);
			}
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x000B46C7 File Offset: 0x000B28C7
		static ABrush()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Brush");
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x000B46D5 File Offset: 0x000B28D5
		protected ABrush(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003C43 RID: 15427
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Brush";

		// Token: 0x04003C44 RID: 15428
		private static IntPtr _ClassPtr;

		// Token: 0x04003C45 RID: 15429
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003C46 RID: 15430
		internal static int __PropertyOffset_BrushType;

		// Token: 0x04003C47 RID: 15431
		internal static int __PropertyOffset_BrushColor;

		// Token: 0x04003C48 RID: 15432
		internal static int __PropertyOffset_PolyFlags;

		// Token: 0x04003C49 RID: 15433
		internal static int __PropertyOffset_bColored;

		// Token: 0x04003C4A RID: 15434
		internal static byte __PropertyMask_bColored;

		// Token: 0x04003C4B RID: 15435
		internal static int __PropertyOffset_bSolidWhenSelected;

		// Token: 0x04003C4C RID: 15436
		internal static byte __PropertyMask_bSolidWhenSelected;

		// Token: 0x04003C4D RID: 15437
		internal static int __PropertyOffset_bPlaceableFromClassBrowser;

		// Token: 0x04003C4E RID: 15438
		internal static byte __PropertyMask_bPlaceableFromClassBrowser;

		// Token: 0x04003C4F RID: 15439
		internal static int __PropertyOffset_bNotForClientOrServer;

		// Token: 0x04003C50 RID: 15440
		internal static byte __PropertyMask_bNotForClientOrServer;

		// Token: 0x04003C51 RID: 15441
		internal static int __PropertyOffset_Brush;

		// Token: 0x04003C52 RID: 15442
		internal static int __PropertyOffset_BrushComponent;

		// Token: 0x04003C53 RID: 15443
		internal static int __PropertyOffset_bInManipulation;

		// Token: 0x04003C54 RID: 15444
		internal static byte __PropertyMask_bInManipulation;

		// Token: 0x04003C55 RID: 15445
		internal static int __PropertyOffset_SavedSelections;

		// Token: 0x04003C56 RID: 15446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGeomSelection> _SavedSelections;
	}
}
