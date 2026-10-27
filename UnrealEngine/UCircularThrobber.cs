using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002946 RID: 10566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.CircularThrobber")]
	[UnrealStructLayout(864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public class UCircularThrobber : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060271D0 RID: 160208 RVA: 0x003BA313 File Offset: 0x003B8513
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCircularThrobber._ClassPtr;
		}

		// Token: 0x060271D1 RID: 160209 RVA: 0x003BA320 File Offset: 0x003B8520
		public UCircularThrobber() : this(BuiltinUtils.AllocNativeUObject(UCircularThrobber.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060271D2 RID: 160210 RVA: 0x003BA348 File Offset: 0x003B8548
		public UCircularThrobber(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCircularThrobber.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009678 RID: 38520
		// (get) Token: 0x060271D3 RID: 160211 RVA: 0x003BA37B File Offset: 0x003B857B
		// (set) Token: 0x060271D4 RID: 160212 RVA: 0x003BA38B File Offset: 0x003B858B
		public unsafe int NumberOfPieces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_NumberOfPieces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_NumberOfPieces) = value;
			}
		}

		// Token: 0x17009679 RID: 38521
		// (get) Token: 0x060271D5 RID: 160213 RVA: 0x003BA39C File Offset: 0x003B859C
		// (set) Token: 0x060271D6 RID: 160214 RVA: 0x003BA3AC File Offset: 0x003B85AC
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x1700967A RID: 38522
		// (get) Token: 0x060271D7 RID: 160215 RVA: 0x003BA3BD File Offset: 0x003B85BD
		// (set) Token: 0x060271D8 RID: 160216 RVA: 0x003BA3CD File Offset: 0x003B85CD
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700967B RID: 38523
		// (get) Token: 0x060271D9 RID: 160217 RVA: 0x003BA3DE File Offset: 0x003B85DE
		// (set) Token: 0x060271DA RID: 160218 RVA: 0x003BA3F2 File Offset: 0x003B85F2
		[Nullable(2)]
		public unsafe USlateBrushAsset PieceImage_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCircularThrobber.__PropertyOffset_PieceImage_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCircularThrobber.__PropertyOffset_PieceImage_DEPRECATED, value);
			}
		}

		// Token: 0x1700967C RID: 38524
		// (get) Token: 0x060271DB RID: 160219 RVA: 0x003BA408 File Offset: 0x003B8608
		// (set) Token: 0x060271DC RID: 160220 RVA: 0x003BA441 File Offset: 0x003B8641
		public FSlateBrush Image
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Image) == null)
				{
					result = (this._Image = new FSlateBrush(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_Image, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_Image, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700967D RID: 38525
		// (get) Token: 0x060271DD RID: 160221 RVA: 0x003BA462 File Offset: 0x003B8662
		// (set) Token: 0x060271DE RID: 160222 RVA: 0x003BA472 File Offset: 0x003B8672
		public unsafe bool bEnableRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_bEnableRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCircularThrobber.__PropertyOffset_bEnableRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x060271DF RID: 160223 RVA: 0x003BA483 File Offset: 0x003B8683
		public void SetRadius(float InRadius)
		{
			UCircularThrobber.__SetRadius_Internal(base.NativePtr, InRadius);
		}

		// Token: 0x060271E0 RID: 160224 RVA: 0x003BA491 File Offset: 0x003B8691
		public void SetPeriod(float InPeriod)
		{
			UCircularThrobber.__SetPeriod_Internal(base.NativePtr, InPeriod);
		}

		// Token: 0x060271E1 RID: 160225 RVA: 0x003BA49F File Offset: 0x003B869F
		public void SetNumberOfPieces(int InNumberOfPieces)
		{
			UCircularThrobber.__SetNumberOfPieces_Internal(base.NativePtr, InNumberOfPieces);
		}

		// Token: 0x060271E2 RID: 160226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadius_Internal(IntPtr @this, float InRadius);

		// Token: 0x060271E3 RID: 160227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPeriod_Internal(IntPtr @this, float InPeriod);

		// Token: 0x060271E4 RID: 160228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumberOfPieces_Internal(IntPtr @this, int InNumberOfPieces);

		// Token: 0x060271E5 RID: 160229 RVA: 0x003BA4AD File Offset: 0x003B86AD
		static UCircularThrobber()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CircularThrobber");
		}

		// Token: 0x060271E6 RID: 160230 RVA: 0x003BA4BB File Offset: 0x003B86BB
		protected UCircularThrobber(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157B4 RID: 87988
		public new const string __ObjectPath = "/Script/UMG.CircularThrobber";

		// Token: 0x040157B5 RID: 87989
		private static IntPtr _ClassPtr;

		// Token: 0x040157B6 RID: 87990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157B7 RID: 87991
		internal static int __PropertyOffset_NumberOfPieces;

		// Token: 0x040157B8 RID: 87992
		internal static int __PropertyOffset_Period;

		// Token: 0x040157B9 RID: 87993
		internal static int __PropertyOffset_Radius;

		// Token: 0x040157BA RID: 87994
		internal static int __PropertyOffset_PieceImage_DEPRECATED;

		// Token: 0x040157BB RID: 87995
		internal static int __PropertyOffset_Image;

		// Token: 0x040157BC RID: 87996
		[Nullable(2)]
		private FSlateBrush _Image;

		// Token: 0x040157BD RID: 87997
		internal static int __PropertyOffset_bEnableRadius;
	}
}
