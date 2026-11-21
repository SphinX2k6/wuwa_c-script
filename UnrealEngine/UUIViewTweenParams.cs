using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200073D RID: 1853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIViewTweenParams")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UUIViewTweenParams : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A18E RID: 41358 RVA: 0x000EEBE9 File Offset: 0x000ECDE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIViewTweenParams._ClassPtr;
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x000EEBF8 File Offset: 0x000ECDF8
		public UUIViewTweenParams() : this(BuiltinUtils.AllocNativeUObject(UUIViewTweenParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x000EEC20 File Offset: 0x000ECE20
		public UUIViewTweenParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIViewTweenParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x0600A191 RID: 41361 RVA: 0x000EEC53 File Offset: 0x000ECE53
		// (set) Token: 0x0600A192 RID: 41362 RVA: 0x000EEC63 File Offset: 0x000ECE63
		public unsafe float TweenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_TweenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_TweenSize) = value;
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x0600A193 RID: 41363 RVA: 0x000EEC74 File Offset: 0x000ECE74
		// (set) Token: 0x0600A194 RID: 41364 RVA: 0x000EEC84 File Offset: 0x000ECE84
		public unsafe float TweenAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_TweenAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_TweenAlpha) = value;
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x0600A195 RID: 41365 RVA: 0x000EEC95 File Offset: 0x000ECE95
		// (set) Token: 0x0600A196 RID: 41366 RVA: 0x000EECA5 File Offset: 0x000ECEA5
		public unsafe float TweenTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_TweenTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_TweenTime) = value;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600A197 RID: 41367 RVA: 0x000EECB8 File Offset: 0x000ECEB8
		// (set) Token: 0x0600A198 RID: 41368 RVA: 0x000EECF1 File Offset: 0x000ECEF1
		public TArray<string> ViewNameBlackList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ViewNameBlackList) == null)
				{
					result = (this._ViewNameBlackList = new TArray<string>(base.NativePtr + (IntPtr)UUIViewTweenParams.__PropertyOffset_ViewNameBlackList, this));
				}
				return result;
			}
			set
			{
				this.ViewNameBlackList.CopyAssign(value);
			}
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x000EECFF File Offset: 0x000ECEFF
		public TArray<string> GetViewNameBlackList()
		{
			return new TArray<string>(UUIViewTweenParams.__GetViewNameBlackList_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x000EED12 File Offset: 0x000ECF12
		public float GetTweenTime()
		{
			return UUIViewTweenParams.__GetTweenTime_Internal(base.NativePtr);
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x000EED1F File Offset: 0x000ECF1F
		public float GetTweenSize()
		{
			return UUIViewTweenParams.__GetTweenSize_Internal(base.NativePtr);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x000EED2C File Offset: 0x000ECF2C
		public float GetTweenAlpha()
		{
			return UUIViewTweenParams.__GetTweenAlpha_Internal(base.NativePtr);
		}

		// Token: 0x0600A19D RID: 41373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewNameBlackList_Internal(IntPtr @this);

		// Token: 0x0600A19E RID: 41374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTweenTime_Internal(IntPtr @this);

		// Token: 0x0600A19F RID: 41375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTweenSize_Internal(IntPtr @this);

		// Token: 0x0600A1A0 RID: 41376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTweenAlpha_Internal(IntPtr @this);

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x000EED39 File Offset: 0x000ECF39
		static UUIViewTweenParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIViewTweenParams");
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x000EED47 File Offset: 0x000ECF47
		protected UUIViewTweenParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400452D RID: 17709
		public new const string __ObjectPath = "/Script/LGUI.UIViewTweenParams";

		// Token: 0x0400452E RID: 17710
		private static IntPtr _ClassPtr;

		// Token: 0x0400452F RID: 17711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004530 RID: 17712
		internal static int __PropertyOffset_TweenSize;

		// Token: 0x04004531 RID: 17713
		internal static int __PropertyOffset_TweenAlpha;

		// Token: 0x04004532 RID: 17714
		internal static int __PropertyOffset_TweenTime;

		// Token: 0x04004533 RID: 17715
		internal static int __PropertyOffset_ViewNameBlackList;

		// Token: 0x04004534 RID: 17716
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ViewNameBlackList;
	}
}
