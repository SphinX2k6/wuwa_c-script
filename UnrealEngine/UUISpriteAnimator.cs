using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000728 RID: 1832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteAnimator")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUISpriteAnimator : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F38 RID: 40760 RVA: 0x000EC5E0 File Offset: 0x000EA7E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteAnimator._ClassPtr;
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x000EC5EC File Offset: 0x000EA7EC
		public UUISpriteAnimator() : this(BuiltinUtils.AllocNativeUObject(UUISpriteAnimator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x000EC614 File Offset: 0x000EA814
		public UUISpriteAnimator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpriteAnimator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x000EC647 File Offset: 0x000EA847
		// (set) Token: 0x06009F3C RID: 40764 RVA: 0x000EC657 File Offset: 0x000EA857
		public unsafe float CurFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpriteAnimator.__PropertyOffset_CurFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpriteAnimator.__PropertyOffset_CurFrame) = value;
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06009F3D RID: 40765 RVA: 0x000EC668 File Offset: 0x000EA868
		// (set) Token: 0x06009F3E RID: 40766 RVA: 0x000EC67C File Offset: 0x000EA87C
		[Nullable(2)]
		public unsafe UUISprite Sprite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISprite>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteAnimator.__PropertyOffset_Sprite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteAnimator.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x000EC694 File Offset: 0x000EA894
		// (set) Token: 0x06009F40 RID: 40768 RVA: 0x000EC6CD File Offset: 0x000EA8CD
		public TArray<ULGUISpriteData_BaseObject> SpriteDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUISpriteData_BaseObject> result;
				if ((result = this._SpriteDatas) == null)
				{
					result = (this._SpriteDatas = new TArray<ULGUISpriteData_BaseObject>(base.NativePtr + (IntPtr)UUISpriteAnimator.__PropertyOffset_SpriteDatas, this));
				}
				return result;
			}
			set
			{
				this.SpriteDatas.CopyAssign(value);
			}
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x000EC6DB File Offset: 0x000EA8DB
		public void SetCurFrame(float newCurFrame)
		{
			UUISpriteAnimator.__SetCurFrame_Internal(base.NativePtr, newCurFrame);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x000EC6E9 File Offset: 0x000EA8E9
		public void ResetSpriteImporter()
		{
			UUISpriteAnimator.__ResetSpriteImporter_Internal(base.NativePtr);
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x000EC6F6 File Offset: 0x000EA8F6
		public float GetCurFrame()
		{
			return UUISpriteAnimator.__GetCurFrame_Internal(base.NativePtr);
		}

		// Token: 0x06009F44 RID: 40772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurFrame_Internal(IntPtr @this, float newCurFrame);

		// Token: 0x06009F45 RID: 40773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetSpriteImporter_Internal(IntPtr @this);

		// Token: 0x06009F46 RID: 40774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurFrame_Internal(IntPtr @this);

		// Token: 0x06009F47 RID: 40775 RVA: 0x000EC703 File Offset: 0x000EA903
		static UUISpriteAnimator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteAnimator");
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x000EC711 File Offset: 0x000EA911
		protected UUISpriteAnimator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004449 RID: 17481
		public new const string __ObjectPath = "/Script/LGUI.UISpriteAnimator";

		// Token: 0x0400444A RID: 17482
		private static IntPtr _ClassPtr;

		// Token: 0x0400444B RID: 17483
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400444C RID: 17484
		internal static int __PropertyOffset_CurFrame;

		// Token: 0x0400444D RID: 17485
		internal static int __PropertyOffset_Sprite;

		// Token: 0x0400444E RID: 17486
		internal static int __PropertyOffset_SpriteDatas;

		// Token: 0x0400444F RID: 17487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUISpriteData_BaseObject> _SpriteDatas;
	}
}
