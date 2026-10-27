using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D6 RID: 10710
	[UnrealObjectPath("/Script/UMG.SizeBox")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class USizeBox : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060279C2 RID: 162242 RVA: 0x003C6AB9 File Offset: 0x003C4CB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USizeBox._ClassPtr;
		}

		// Token: 0x060279C3 RID: 162243 RVA: 0x003C6AC8 File Offset: 0x003C4CC8
		public USizeBox() : this(BuiltinUtils.AllocNativeUObject(USizeBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060279C4 RID: 162244 RVA: 0x003C6AF0 File Offset: 0x003C4CF0
		[NullableContext(1)]
		public USizeBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USizeBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097C3 RID: 38851
		// (get) Token: 0x060279C5 RID: 162245 RVA: 0x003C6B23 File Offset: 0x003C4D23
		// (set) Token: 0x060279C6 RID: 162246 RVA: 0x003C6B33 File Offset: 0x003C4D33
		public unsafe float WidthOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_WidthOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_WidthOverride) = value;
			}
		}

		// Token: 0x170097C4 RID: 38852
		// (get) Token: 0x060279C7 RID: 162247 RVA: 0x003C6B44 File Offset: 0x003C4D44
		// (set) Token: 0x060279C8 RID: 162248 RVA: 0x003C6B54 File Offset: 0x003C4D54
		public unsafe float HeightOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_HeightOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_HeightOverride) = value;
			}
		}

		// Token: 0x170097C5 RID: 38853
		// (get) Token: 0x060279C9 RID: 162249 RVA: 0x003C6B65 File Offset: 0x003C4D65
		// (set) Token: 0x060279CA RID: 162250 RVA: 0x003C6B75 File Offset: 0x003C4D75
		public unsafe float MinDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MinDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MinDesiredWidth) = value;
			}
		}

		// Token: 0x170097C6 RID: 38854
		// (get) Token: 0x060279CB RID: 162251 RVA: 0x003C6B86 File Offset: 0x003C4D86
		// (set) Token: 0x060279CC RID: 162252 RVA: 0x003C6B96 File Offset: 0x003C4D96
		public unsafe float MinDesiredHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MinDesiredHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MinDesiredHeight) = value;
			}
		}

		// Token: 0x170097C7 RID: 38855
		// (get) Token: 0x060279CD RID: 162253 RVA: 0x003C6BA7 File Offset: 0x003C4DA7
		// (set) Token: 0x060279CE RID: 162254 RVA: 0x003C6BB7 File Offset: 0x003C4DB7
		public unsafe float MaxDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MaxDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MaxDesiredWidth) = value;
			}
		}

		// Token: 0x170097C8 RID: 38856
		// (get) Token: 0x060279CF RID: 162255 RVA: 0x003C6BC8 File Offset: 0x003C4DC8
		// (set) Token: 0x060279D0 RID: 162256 RVA: 0x003C6BD8 File Offset: 0x003C4DD8
		public unsafe float MaxDesiredHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MaxDesiredHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MaxDesiredHeight) = value;
			}
		}

		// Token: 0x170097C9 RID: 38857
		// (get) Token: 0x060279D1 RID: 162257 RVA: 0x003C6BE9 File Offset: 0x003C4DE9
		// (set) Token: 0x060279D2 RID: 162258 RVA: 0x003C6BF9 File Offset: 0x003C4DF9
		public unsafe float MinAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MinAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MinAspectRatio) = value;
			}
		}

		// Token: 0x170097CA RID: 38858
		// (get) Token: 0x060279D3 RID: 162259 RVA: 0x003C6C0A File Offset: 0x003C4E0A
		// (set) Token: 0x060279D4 RID: 162260 RVA: 0x003C6C1A File Offset: 0x003C4E1A
		public unsafe float MaxAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MaxAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_MaxAspectRatio) = value;
			}
		}

		// Token: 0x170097CB RID: 38859
		// (get) Token: 0x060279D5 RID: 162261 RVA: 0x003C6C2B File Offset: 0x003C4E2B
		// (set) Token: 0x060279D6 RID: 162262 RVA: 0x003C6C44 File Offset: 0x003C4E44
		public unsafe bool bOverride_WidthOverride
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_WidthOverride) & USizeBox.__PropertyMask_bOverride_WidthOverride) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_WidthOverride) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_WidthOverride) & ~USizeBox.__PropertyMask_bOverride_WidthOverride) | (value ? USizeBox.__PropertyMask_bOverride_WidthOverride : 0));
			}
		}

		// Token: 0x170097CC RID: 38860
		// (get) Token: 0x060279D7 RID: 162263 RVA: 0x003C6C74 File Offset: 0x003C4E74
		// (set) Token: 0x060279D8 RID: 162264 RVA: 0x003C6C8D File Offset: 0x003C4E8D
		public unsafe bool bOverride_HeightOverride
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_HeightOverride) & USizeBox.__PropertyMask_bOverride_HeightOverride) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_HeightOverride) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_HeightOverride) & ~USizeBox.__PropertyMask_bOverride_HeightOverride) | (value ? USizeBox.__PropertyMask_bOverride_HeightOverride : 0));
			}
		}

		// Token: 0x170097CD RID: 38861
		// (get) Token: 0x060279D9 RID: 162265 RVA: 0x003C6CBD File Offset: 0x003C4EBD
		// (set) Token: 0x060279DA RID: 162266 RVA: 0x003C6CD6 File Offset: 0x003C4ED6
		public unsafe bool bOverride_MinDesiredWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinDesiredWidth) & USizeBox.__PropertyMask_bOverride_MinDesiredWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinDesiredWidth) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinDesiredWidth) & ~USizeBox.__PropertyMask_bOverride_MinDesiredWidth) | (value ? USizeBox.__PropertyMask_bOverride_MinDesiredWidth : 0));
			}
		}

		// Token: 0x170097CE RID: 38862
		// (get) Token: 0x060279DB RID: 162267 RVA: 0x003C6D06 File Offset: 0x003C4F06
		// (set) Token: 0x060279DC RID: 162268 RVA: 0x003C6D1F File Offset: 0x003C4F1F
		public unsafe bool bOverride_MinDesiredHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinDesiredHeight) & USizeBox.__PropertyMask_bOverride_MinDesiredHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinDesiredHeight) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinDesiredHeight) & ~USizeBox.__PropertyMask_bOverride_MinDesiredHeight) | (value ? USizeBox.__PropertyMask_bOverride_MinDesiredHeight : 0));
			}
		}

		// Token: 0x170097CF RID: 38863
		// (get) Token: 0x060279DD RID: 162269 RVA: 0x003C6D4F File Offset: 0x003C4F4F
		// (set) Token: 0x060279DE RID: 162270 RVA: 0x003C6D68 File Offset: 0x003C4F68
		public unsafe bool bOverride_MaxDesiredWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxDesiredWidth) & USizeBox.__PropertyMask_bOverride_MaxDesiredWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxDesiredWidth) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxDesiredWidth) & ~USizeBox.__PropertyMask_bOverride_MaxDesiredWidth) | (value ? USizeBox.__PropertyMask_bOverride_MaxDesiredWidth : 0));
			}
		}

		// Token: 0x170097D0 RID: 38864
		// (get) Token: 0x060279DF RID: 162271 RVA: 0x003C6D98 File Offset: 0x003C4F98
		// (set) Token: 0x060279E0 RID: 162272 RVA: 0x003C6DB1 File Offset: 0x003C4FB1
		public unsafe bool bOverride_MaxDesiredHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxDesiredHeight) & USizeBox.__PropertyMask_bOverride_MaxDesiredHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxDesiredHeight) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxDesiredHeight) & ~USizeBox.__PropertyMask_bOverride_MaxDesiredHeight) | (value ? USizeBox.__PropertyMask_bOverride_MaxDesiredHeight : 0));
			}
		}

		// Token: 0x170097D1 RID: 38865
		// (get) Token: 0x060279E1 RID: 162273 RVA: 0x003C6DE1 File Offset: 0x003C4FE1
		// (set) Token: 0x060279E2 RID: 162274 RVA: 0x003C6DFA File Offset: 0x003C4FFA
		public unsafe bool bOverride_MinAspectRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinAspectRatio) & USizeBox.__PropertyMask_bOverride_MinAspectRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinAspectRatio) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MinAspectRatio) & ~USizeBox.__PropertyMask_bOverride_MinAspectRatio) | (value ? USizeBox.__PropertyMask_bOverride_MinAspectRatio : 0));
			}
		}

		// Token: 0x170097D2 RID: 38866
		// (get) Token: 0x060279E3 RID: 162275 RVA: 0x003C6E2A File Offset: 0x003C502A
		// (set) Token: 0x060279E4 RID: 162276 RVA: 0x003C6E43 File Offset: 0x003C5043
		public unsafe bool bOverride_MaxAspectRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxAspectRatio) & USizeBox.__PropertyMask_bOverride_MaxAspectRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxAspectRatio) = ((*(base.NativePtr + (IntPtr)USizeBox.__PropertyOffset_bOverride_MaxAspectRatio) & ~USizeBox.__PropertyMask_bOverride_MaxAspectRatio) | (value ? USizeBox.__PropertyMask_bOverride_MaxAspectRatio : 0));
			}
		}

		// Token: 0x060279E5 RID: 162277 RVA: 0x003C6E73 File Offset: 0x003C5073
		public void SetWidthOverride(float InWidthOverride)
		{
			USizeBox.__SetWidthOverride_Internal(base.NativePtr, InWidthOverride);
		}

		// Token: 0x060279E6 RID: 162278 RVA: 0x003C6E81 File Offset: 0x003C5081
		public void SetMinDesiredWidth(float InMinDesiredWidth)
		{
			USizeBox.__SetMinDesiredWidth_Internal(base.NativePtr, InMinDesiredWidth);
		}

		// Token: 0x060279E7 RID: 162279 RVA: 0x003C6E8F File Offset: 0x003C508F
		public void SetMinDesiredHeight(float InMinDesiredHeight)
		{
			USizeBox.__SetMinDesiredHeight_Internal(base.NativePtr, InMinDesiredHeight);
		}

		// Token: 0x060279E8 RID: 162280 RVA: 0x003C6E9D File Offset: 0x003C509D
		public void SetMinAspectRatio(float InMinAspectRatio)
		{
			USizeBox.__SetMinAspectRatio_Internal(base.NativePtr, InMinAspectRatio);
		}

		// Token: 0x060279E9 RID: 162281 RVA: 0x003C6EAB File Offset: 0x003C50AB
		public void SetMaxDesiredWidth(float InMaxDesiredWidth)
		{
			USizeBox.__SetMaxDesiredWidth_Internal(base.NativePtr, InMaxDesiredWidth);
		}

		// Token: 0x060279EA RID: 162282 RVA: 0x003C6EB9 File Offset: 0x003C50B9
		public void SetMaxDesiredHeight(float InMaxDesiredHeight)
		{
			USizeBox.__SetMaxDesiredHeight_Internal(base.NativePtr, InMaxDesiredHeight);
		}

		// Token: 0x060279EB RID: 162283 RVA: 0x003C6EC7 File Offset: 0x003C50C7
		public void SetMaxAspectRatio(float InMaxAspectRatio)
		{
			USizeBox.__SetMaxAspectRatio_Internal(base.NativePtr, InMaxAspectRatio);
		}

		// Token: 0x060279EC RID: 162284 RVA: 0x003C6ED5 File Offset: 0x003C50D5
		public void SetHeightOverride(float InHeightOverride)
		{
			USizeBox.__SetHeightOverride_Internal(base.NativePtr, InHeightOverride);
		}

		// Token: 0x060279ED RID: 162285 RVA: 0x003C6EE3 File Offset: 0x003C50E3
		public void ClearWidthOverride()
		{
			USizeBox.__ClearWidthOverride_Internal(base.NativePtr);
		}

		// Token: 0x060279EE RID: 162286 RVA: 0x003C6EF0 File Offset: 0x003C50F0
		public void ClearMinDesiredWidth()
		{
			USizeBox.__ClearMinDesiredWidth_Internal(base.NativePtr);
		}

		// Token: 0x060279EF RID: 162287 RVA: 0x003C6EFD File Offset: 0x003C50FD
		public void ClearMinDesiredHeight()
		{
			USizeBox.__ClearMinDesiredHeight_Internal(base.NativePtr);
		}

		// Token: 0x060279F0 RID: 162288 RVA: 0x003C6F0A File Offset: 0x003C510A
		public void ClearMinAspectRatio()
		{
			USizeBox.__ClearMinAspectRatio_Internal(base.NativePtr);
		}

		// Token: 0x060279F1 RID: 162289 RVA: 0x003C6F17 File Offset: 0x003C5117
		public void ClearMaxDesiredWidth()
		{
			USizeBox.__ClearMaxDesiredWidth_Internal(base.NativePtr);
		}

		// Token: 0x060279F2 RID: 162290 RVA: 0x003C6F24 File Offset: 0x003C5124
		public void ClearMaxDesiredHeight()
		{
			USizeBox.__ClearMaxDesiredHeight_Internal(base.NativePtr);
		}

		// Token: 0x060279F3 RID: 162291 RVA: 0x003C6F31 File Offset: 0x003C5131
		public void ClearMaxAspectRatio()
		{
			USizeBox.__ClearMaxAspectRatio_Internal(base.NativePtr);
		}

		// Token: 0x060279F4 RID: 162292 RVA: 0x003C6F3E File Offset: 0x003C513E
		public void ClearHeightOverride()
		{
			USizeBox.__ClearHeightOverride_Internal(base.NativePtr);
		}

		// Token: 0x060279F5 RID: 162293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthOverride_Internal(IntPtr @this, float InWidthOverride);

		// Token: 0x060279F6 RID: 162294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredWidth_Internal(IntPtr @this, float InMinDesiredWidth);

		// Token: 0x060279F7 RID: 162295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredHeight_Internal(IntPtr @this, float InMinDesiredHeight);

		// Token: 0x060279F8 RID: 162296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinAspectRatio_Internal(IntPtr @this, float InMinAspectRatio);

		// Token: 0x060279F9 RID: 162297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDesiredWidth_Internal(IntPtr @this, float InMaxDesiredWidth);

		// Token: 0x060279FA RID: 162298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDesiredHeight_Internal(IntPtr @this, float InMaxDesiredHeight);

		// Token: 0x060279FB RID: 162299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxAspectRatio_Internal(IntPtr @this, float InMaxAspectRatio);

		// Token: 0x060279FC RID: 162300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightOverride_Internal(IntPtr @this, float InHeightOverride);

		// Token: 0x060279FD RID: 162301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWidthOverride_Internal(IntPtr @this);

		// Token: 0x060279FE RID: 162302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMinDesiredWidth_Internal(IntPtr @this);

		// Token: 0x060279FF RID: 162303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMinDesiredHeight_Internal(IntPtr @this);

		// Token: 0x06027A00 RID: 162304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMinAspectRatio_Internal(IntPtr @this);

		// Token: 0x06027A01 RID: 162305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMaxDesiredWidth_Internal(IntPtr @this);

		// Token: 0x06027A02 RID: 162306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMaxDesiredHeight_Internal(IntPtr @this);

		// Token: 0x06027A03 RID: 162307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMaxAspectRatio_Internal(IntPtr @this);

		// Token: 0x06027A04 RID: 162308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearHeightOverride_Internal(IntPtr @this);

		// Token: 0x06027A05 RID: 162309 RVA: 0x003C6F4B File Offset: 0x003C514B
		static USizeBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SizeBox");
		}

		// Token: 0x06027A06 RID: 162310 RVA: 0x003C6F59 File Offset: 0x003C5159
		protected USizeBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B40 RID: 88896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.SizeBox";

		// Token: 0x04015B41 RID: 88897
		private static IntPtr _ClassPtr;

		// Token: 0x04015B42 RID: 88898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B43 RID: 88899
		internal static int __PropertyOffset_WidthOverride;

		// Token: 0x04015B44 RID: 88900
		internal static int __PropertyOffset_HeightOverride;

		// Token: 0x04015B45 RID: 88901
		internal static int __PropertyOffset_MinDesiredWidth;

		// Token: 0x04015B46 RID: 88902
		internal static int __PropertyOffset_MinDesiredHeight;

		// Token: 0x04015B47 RID: 88903
		internal static int __PropertyOffset_MaxDesiredWidth;

		// Token: 0x04015B48 RID: 88904
		internal static int __PropertyOffset_MaxDesiredHeight;

		// Token: 0x04015B49 RID: 88905
		internal static int __PropertyOffset_MinAspectRatio;

		// Token: 0x04015B4A RID: 88906
		internal static int __PropertyOffset_MaxAspectRatio;

		// Token: 0x04015B4B RID: 88907
		internal static int __PropertyOffset_bOverride_WidthOverride;

		// Token: 0x04015B4C RID: 88908
		internal static byte __PropertyMask_bOverride_WidthOverride;

		// Token: 0x04015B4D RID: 88909
		internal static int __PropertyOffset_bOverride_HeightOverride;

		// Token: 0x04015B4E RID: 88910
		internal static byte __PropertyMask_bOverride_HeightOverride;

		// Token: 0x04015B4F RID: 88911
		internal static int __PropertyOffset_bOverride_MinDesiredWidth;

		// Token: 0x04015B50 RID: 88912
		internal static byte __PropertyMask_bOverride_MinDesiredWidth;

		// Token: 0x04015B51 RID: 88913
		internal static int __PropertyOffset_bOverride_MinDesiredHeight;

		// Token: 0x04015B52 RID: 88914
		internal static byte __PropertyMask_bOverride_MinDesiredHeight;

		// Token: 0x04015B53 RID: 88915
		internal static int __PropertyOffset_bOverride_MaxDesiredWidth;

		// Token: 0x04015B54 RID: 88916
		internal static byte __PropertyMask_bOverride_MaxDesiredWidth;

		// Token: 0x04015B55 RID: 88917
		internal static int __PropertyOffset_bOverride_MaxDesiredHeight;

		// Token: 0x04015B56 RID: 88918
		internal static byte __PropertyMask_bOverride_MaxDesiredHeight;

		// Token: 0x04015B57 RID: 88919
		internal static int __PropertyOffset_bOverride_MinAspectRatio;

		// Token: 0x04015B58 RID: 88920
		internal static byte __PropertyMask_bOverride_MinAspectRatio;

		// Token: 0x04015B59 RID: 88921
		internal static int __PropertyOffset_bOverride_MaxAspectRatio;

		// Token: 0x04015B5A RID: 88922
		internal static byte __PropertyMask_bOverride_MaxAspectRatio;
	}
}
