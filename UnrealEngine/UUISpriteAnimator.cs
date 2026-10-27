using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021BB RID: 8635
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteAnimator")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUISpriteAnimator : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020DDA RID: 134618 RVA: 0x00308C73 File Offset: 0x00306E73
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteAnimator._ClassPtr;
		}

		// Token: 0x06020DDB RID: 134619 RVA: 0x00308C80 File Offset: 0x00306E80
		public UUISpriteAnimator() : this(BuiltinUtils.AllocNativeUObject(UUISpriteAnimator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020DDC RID: 134620 RVA: 0x00308CA8 File Offset: 0x00306EA8
		[NullableContext(1)]
		public UUISpriteAnimator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpriteAnimator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008060 RID: 32864
		// (get) Token: 0x06020DDD RID: 134621 RVA: 0x00308CDB File Offset: 0x00306EDB
		// (set) Token: 0x06020DDE RID: 134622 RVA: 0x00308CEB File Offset: 0x00306EEB
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

		// Token: 0x17008061 RID: 32865
		// (get) Token: 0x06020DDF RID: 134623 RVA: 0x00308CFC File Offset: 0x00306EFC
		// (set) Token: 0x06020DE0 RID: 134624 RVA: 0x00308D10 File Offset: 0x00306F10
		public unsafe UUISprite Sprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISprite>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteAnimator.__PropertyOffset_Sprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteAnimator.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x17008062 RID: 32866
		// (get) Token: 0x06020DE1 RID: 134625 RVA: 0x00308D25 File Offset: 0x00306F25
		// (set) Token: 0x06020DE2 RID: 134626 RVA: 0x00308D39 File Offset: 0x00306F39
		public unsafe ULGUISpriteData_BaseImporter CurSpriteImporter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseImporter>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteAnimator.__PropertyOffset_CurSpriteImporter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteAnimator.__PropertyOffset_CurSpriteImporter, value);
			}
		}

		// Token: 0x17008063 RID: 32867
		// (get) Token: 0x06020DE3 RID: 134627 RVA: 0x00308D50 File Offset: 0x00306F50
		// (set) Token: 0x06020DE4 RID: 134628 RVA: 0x00308D89 File Offset: 0x00306F89
		[Nullable(1)]
		public TArray<ULGUISpriteData_BaseObject> SpriteDatas
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.SpriteDatas.CopyAssign(value);
			}
		}

		// Token: 0x06020DE5 RID: 134629 RVA: 0x00308D97 File Offset: 0x00306F97
		public void SetCurFrame(float newCurFrame)
		{
			UUISpriteAnimator.__SetCurFrame_Internal(base.NativePtr, newCurFrame);
		}

		// Token: 0x06020DE6 RID: 134630 RVA: 0x00308DA5 File Offset: 0x00306FA5
		public void ResetSpriteImporter()
		{
			UUISpriteAnimator.__ResetSpriteImporter_Internal(base.NativePtr);
		}

		// Token: 0x06020DE7 RID: 134631 RVA: 0x00308DB2 File Offset: 0x00306FB2
		public float GetCurFrame()
		{
			return UUISpriteAnimator.__GetCurFrame_Internal(base.NativePtr);
		}

		// Token: 0x06020DE8 RID: 134632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurFrame_Internal(IntPtr @this, float newCurFrame);

		// Token: 0x06020DE9 RID: 134633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetSpriteImporter_Internal(IntPtr @this);

		// Token: 0x06020DEA RID: 134634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurFrame_Internal(IntPtr @this);

		// Token: 0x06020DEB RID: 134635 RVA: 0x00308DBF File Offset: 0x00306FBF
		static UUISpriteAnimator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteAnimator");
		}

		// Token: 0x06020DEC RID: 134636 RVA: 0x00308DCD File Offset: 0x00306FCD
		protected UUISpriteAnimator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118D2 RID: 71890
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteAnimator";

		// Token: 0x040118D3 RID: 71891
		private static IntPtr _ClassPtr;

		// Token: 0x040118D4 RID: 71892
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118D5 RID: 71893
		internal static int __PropertyOffset_CurFrame;

		// Token: 0x040118D6 RID: 71894
		internal static int __PropertyOffset_Sprite;

		// Token: 0x040118D7 RID: 71895
		internal static int __PropertyOffset_CurSpriteImporter;

		// Token: 0x040118D8 RID: 71896
		internal static int __PropertyOffset_SpriteDatas;

		// Token: 0x040118D9 RID: 71897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUISpriteData_BaseObject> _SpriteDatas;
	}
}
