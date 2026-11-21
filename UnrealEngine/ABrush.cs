using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000196 RID: 406
	[UnrealObjectPath("/Script/Engine.Brush")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ABrush : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B3E RID: 6974 RVA: 0x000288D4 File Offset: 0x00026AD4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABrush._ClassPtr;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000288E0 File Offset: 0x00026AE0
		public ABrush() : this(BuiltinUtils.AllocNativeUObject(ABrush.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00028908 File Offset: 0x00026B08
		[NullableContext(1)]
		public ABrush(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABrush.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x0002893B File Offset: 0x00026B3B
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0002894F File Offset: 0x00026B4F
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

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00028964 File Offset: 0x00026B64
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x00028974 File Offset: 0x00026B74
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00028985 File Offset: 0x00026B85
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0002899E File Offset: 0x00026B9E
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000289CE File Offset: 0x00026BCE
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x000289E7 File Offset: 0x00026BE7
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00028A17 File Offset: 0x00026C17
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00028A30 File Offset: 0x00026C30
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00028A60 File Offset: 0x00026C60
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00028A79 File Offset: 0x00026C79
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00028AA9 File Offset: 0x00026CA9
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00028ABD File Offset: 0x00026CBD
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00028AD2 File Offset: 0x00026CD2
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00028AEB File Offset: 0x00026CEB
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

		// Token: 0x06001B51 RID: 6993 RVA: 0x00028B1B File Offset: 0x00026D1B
		static ABrush()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Brush");
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00028B29 File Offset: 0x00026D29
		protected ABrush(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008C5 RID: 2245
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Brush";

		// Token: 0x040008C6 RID: 2246
		private static IntPtr _ClassPtr;

		// Token: 0x040008C7 RID: 2247
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008C8 RID: 2248
		internal static int __PropertyOffset_BrushColor;

		// Token: 0x040008C9 RID: 2249
		internal static int __PropertyOffset_PolyFlags;

		// Token: 0x040008CA RID: 2250
		internal static int __PropertyOffset_bColored;

		// Token: 0x040008CB RID: 2251
		internal static byte __PropertyMask_bColored;

		// Token: 0x040008CC RID: 2252
		internal static int __PropertyOffset_bSolidWhenSelected;

		// Token: 0x040008CD RID: 2253
		internal static byte __PropertyMask_bSolidWhenSelected;

		// Token: 0x040008CE RID: 2254
		internal static int __PropertyOffset_bPlaceableFromClassBrowser;

		// Token: 0x040008CF RID: 2255
		internal static byte __PropertyMask_bPlaceableFromClassBrowser;

		// Token: 0x040008D0 RID: 2256
		internal static int __PropertyOffset_bNotForClientOrServer;

		// Token: 0x040008D1 RID: 2257
		internal static byte __PropertyMask_bNotForClientOrServer;

		// Token: 0x040008D2 RID: 2258
		internal static int __PropertyOffset_BrushComponent;

		// Token: 0x040008D3 RID: 2259
		internal static int __PropertyOffset_bInManipulation;

		// Token: 0x040008D4 RID: 2260
		internal static byte __PropertyMask_bInManipulation;
	}
}
