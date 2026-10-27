using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E3 RID: 10723
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Throbber")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UThrobber : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027B8C RID: 162700 RVA: 0x003C8EB5 File Offset: 0x003C70B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UThrobber._ClassPtr;
		}

		// Token: 0x06027B8D RID: 162701 RVA: 0x003C8EC4 File Offset: 0x003C70C4
		public UThrobber() : this(BuiltinUtils.AllocNativeUObject(UThrobber.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027B8E RID: 162702 RVA: 0x003C8EEC File Offset: 0x003C70EC
		public UThrobber(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UThrobber.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009830 RID: 38960
		// (get) Token: 0x06027B8F RID: 162703 RVA: 0x003C8F1F File Offset: 0x003C711F
		// (set) Token: 0x06027B90 RID: 162704 RVA: 0x003C8F2F File Offset: 0x003C712F
		public unsafe int NumberOfPieces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_NumberOfPieces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_NumberOfPieces) = value;
			}
		}

		// Token: 0x17009831 RID: 38961
		// (get) Token: 0x06027B91 RID: 162705 RVA: 0x003C8F40 File Offset: 0x003C7140
		// (set) Token: 0x06027B92 RID: 162706 RVA: 0x003C8F50 File Offset: 0x003C7150
		public unsafe bool bAnimateHorizontally
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_bAnimateHorizontally) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_bAnimateHorizontally) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009832 RID: 38962
		// (get) Token: 0x06027B93 RID: 162707 RVA: 0x003C8F61 File Offset: 0x003C7161
		// (set) Token: 0x06027B94 RID: 162708 RVA: 0x003C8F71 File Offset: 0x003C7171
		public unsafe bool bAnimateVertically
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_bAnimateVertically) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_bAnimateVertically) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009833 RID: 38963
		// (get) Token: 0x06027B95 RID: 162709 RVA: 0x003C8F82 File Offset: 0x003C7182
		// (set) Token: 0x06027B96 RID: 162710 RVA: 0x003C8F92 File Offset: 0x003C7192
		public unsafe bool bAnimateOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_bAnimateOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_bAnimateOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009834 RID: 38964
		// (get) Token: 0x06027B97 RID: 162711 RVA: 0x003C8FA3 File Offset: 0x003C71A3
		// (set) Token: 0x06027B98 RID: 162712 RVA: 0x003C8FB7 File Offset: 0x003C71B7
		[Nullable(2)]
		public unsafe USlateBrushAsset PieceImage_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UThrobber.__PropertyOffset_PieceImage_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UThrobber.__PropertyOffset_PieceImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009835 RID: 38965
		// (get) Token: 0x06027B99 RID: 162713 RVA: 0x003C8FCC File Offset: 0x003C71CC
		// (set) Token: 0x06027B9A RID: 162714 RVA: 0x003C9005 File Offset: 0x003C7205
		public FSlateBrush Image
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Image) == null)
				{
					result = (this._Image = new FSlateBrush(base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_Image, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UThrobber.__PropertyOffset_Image, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027B9B RID: 162715 RVA: 0x003C9026 File Offset: 0x003C7226
		public void SetNumberOfPieces(int InNumberOfPieces)
		{
			UThrobber.__SetNumberOfPieces_Internal(base.NativePtr, InNumberOfPieces);
		}

		// Token: 0x06027B9C RID: 162716 RVA: 0x003C9034 File Offset: 0x003C7234
		public void SetAnimateVertically(bool bInAnimateVertically)
		{
			UThrobber.__SetAnimateVertically_Internal(base.NativePtr, bInAnimateVertically);
		}

		// Token: 0x06027B9D RID: 162717 RVA: 0x003C9042 File Offset: 0x003C7242
		public void SetAnimateOpacity(bool bInAnimateOpacity)
		{
			UThrobber.__SetAnimateOpacity_Internal(base.NativePtr, bInAnimateOpacity);
		}

		// Token: 0x06027B9E RID: 162718 RVA: 0x003C9050 File Offset: 0x003C7250
		public void SetAnimateHorizontally(bool bInAnimateHorizontally)
		{
			UThrobber.__SetAnimateHorizontally_Internal(base.NativePtr, bInAnimateHorizontally);
		}

		// Token: 0x06027B9F RID: 162719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumberOfPieces_Internal(IntPtr @this, int InNumberOfPieces);

		// Token: 0x06027BA0 RID: 162720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimateVertically_Internal(IntPtr @this, bool bInAnimateVertically);

		// Token: 0x06027BA1 RID: 162721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimateOpacity_Internal(IntPtr @this, bool bInAnimateOpacity);

		// Token: 0x06027BA2 RID: 162722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimateHorizontally_Internal(IntPtr @this, bool bInAnimateHorizontally);

		// Token: 0x06027BA3 RID: 162723 RVA: 0x003C905E File Offset: 0x003C725E
		static UThrobber()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Throbber");
		}

		// Token: 0x06027BA4 RID: 162724 RVA: 0x003C906C File Offset: 0x003C726C
		protected UThrobber(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C00 RID: 89088
		public new const string __ObjectPath = "/Script/UMG.Throbber";

		// Token: 0x04015C01 RID: 89089
		private static IntPtr _ClassPtr;

		// Token: 0x04015C02 RID: 89090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C03 RID: 89091
		internal static int __PropertyOffset_NumberOfPieces;

		// Token: 0x04015C04 RID: 89092
		internal static int __PropertyOffset_bAnimateHorizontally;

		// Token: 0x04015C05 RID: 89093
		internal static int __PropertyOffset_bAnimateVertically;

		// Token: 0x04015C06 RID: 89094
		internal static int __PropertyOffset_bAnimateOpacity;

		// Token: 0x04015C07 RID: 89095
		internal static int __PropertyOffset_PieceImage_DEPRECATED;

		// Token: 0x04015C08 RID: 89096
		internal static int __PropertyOffset_Image;

		// Token: 0x04015C09 RID: 89097
		[Nullable(2)]
		private FSlateBrush _Image;
	}
}
