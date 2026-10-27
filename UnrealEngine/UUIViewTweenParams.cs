using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E1 RID: 8673
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIViewTweenParams")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UUIViewTweenParams : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021117 RID: 135447 RVA: 0x0030C3CD File Offset: 0x0030A5CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIViewTweenParams._ClassPtr;
		}

		// Token: 0x06021118 RID: 135448 RVA: 0x0030C3DC File Offset: 0x0030A5DC
		public UUIViewTweenParams() : this(BuiltinUtils.AllocNativeUObject(UUIViewTweenParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021119 RID: 135449 RVA: 0x0030C404 File Offset: 0x0030A604
		public UUIViewTweenParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIViewTweenParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700810F RID: 33039
		// (get) Token: 0x0602111A RID: 135450 RVA: 0x0030C437 File Offset: 0x0030A637
		// (set) Token: 0x0602111B RID: 135451 RVA: 0x0030C447 File Offset: 0x0030A647
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

		// Token: 0x17008110 RID: 33040
		// (get) Token: 0x0602111C RID: 135452 RVA: 0x0030C458 File Offset: 0x0030A658
		// (set) Token: 0x0602111D RID: 135453 RVA: 0x0030C468 File Offset: 0x0030A668
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

		// Token: 0x17008111 RID: 33041
		// (get) Token: 0x0602111E RID: 135454 RVA: 0x0030C479 File Offset: 0x0030A679
		// (set) Token: 0x0602111F RID: 135455 RVA: 0x0030C489 File Offset: 0x0030A689
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

		// Token: 0x17008112 RID: 33042
		// (get) Token: 0x06021120 RID: 135456 RVA: 0x0030C49C File Offset: 0x0030A69C
		// (set) Token: 0x06021121 RID: 135457 RVA: 0x0030C4D5 File Offset: 0x0030A6D5
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

		// Token: 0x06021122 RID: 135458 RVA: 0x0030C4E3 File Offset: 0x0030A6E3
		public TArray<string> GetViewNameBlackList()
		{
			return new TArray<string>(UUIViewTweenParams.__GetViewNameBlackList_Internal(base.NativePtr), null);
		}

		// Token: 0x06021123 RID: 135459 RVA: 0x0030C4F6 File Offset: 0x0030A6F6
		public float GetTweenTime()
		{
			return UUIViewTweenParams.__GetTweenTime_Internal(base.NativePtr);
		}

		// Token: 0x06021124 RID: 135460 RVA: 0x0030C503 File Offset: 0x0030A703
		public float GetTweenSize()
		{
			return UUIViewTweenParams.__GetTweenSize_Internal(base.NativePtr);
		}

		// Token: 0x06021125 RID: 135461 RVA: 0x0030C510 File Offset: 0x0030A710
		public float GetTweenAlpha()
		{
			return UUIViewTweenParams.__GetTweenAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06021126 RID: 135462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewNameBlackList_Internal(IntPtr @this);

		// Token: 0x06021127 RID: 135463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTweenTime_Internal(IntPtr @this);

		// Token: 0x06021128 RID: 135464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTweenSize_Internal(IntPtr @this);

		// Token: 0x06021129 RID: 135465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTweenAlpha_Internal(IntPtr @this);

		// Token: 0x0602112A RID: 135466 RVA: 0x0030C51D File Offset: 0x0030A71D
		static UUIViewTweenParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIViewTweenParams");
		}

		// Token: 0x0602112B RID: 135467 RVA: 0x0030C52B File Offset: 0x0030A72B
		protected UUIViewTweenParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A41 RID: 72257
		public new const string __ObjectPath = "/Script/LGUI.UIViewTweenParams";

		// Token: 0x04011A42 RID: 72258
		private static IntPtr _ClassPtr;

		// Token: 0x04011A43 RID: 72259
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A44 RID: 72260
		internal static int __PropertyOffset_TweenSize;

		// Token: 0x04011A45 RID: 72261
		internal static int __PropertyOffset_TweenAlpha;

		// Token: 0x04011A46 RID: 72262
		internal static int __PropertyOffset_TweenTime;

		// Token: 0x04011A47 RID: 72263
		internal static int __PropertyOffset_ViewNameBlackList;

		// Token: 0x04011A48 RID: 72264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ViewNameBlackList;
	}
}
