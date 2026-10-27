using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021C2 RID: 8642
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteSequencePlayer")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UUISpriteSequencePlayer : ULGUIImageSequencePlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E0D RID: 134669 RVA: 0x00308FCD File Offset: 0x003071CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteSequencePlayer._ClassPtr;
		}

		// Token: 0x06020E0E RID: 134670 RVA: 0x00308FDC File Offset: 0x003071DC
		public UUISpriteSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(UUISpriteSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E0F RID: 134671 RVA: 0x00309004 File Offset: 0x00307204
		public UUISpriteSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpriteSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008068 RID: 32872
		// (get) Token: 0x06020E10 RID: 134672 RVA: 0x00309037 File Offset: 0x00307237
		// (set) Token: 0x06020E11 RID: 134673 RVA: 0x0030904B File Offset: 0x0030724B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISpriteBase> sprite
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpriteSequencePlayer.__PropertyOffset_sprite);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISpriteSequencePlayer.__PropertyOffset_sprite) = value;
			}
		}

		// Token: 0x17008069 RID: 32873
		// (get) Token: 0x06020E12 RID: 134674 RVA: 0x00309060 File Offset: 0x00307260
		// (set) Token: 0x06020E13 RID: 134675 RVA: 0x00309099 File Offset: 0x00307299
		public TArray<ULGUISpriteData_BaseObject> spriteSequence
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUISpriteData_BaseObject> result;
				if ((result = this._spriteSequence) == null)
				{
					result = (this._spriteSequence = new TArray<ULGUISpriteData_BaseObject>(base.NativePtr + (IntPtr)UUISpriteSequencePlayer.__PropertyOffset_spriteSequence, this));
				}
				return result;
			}
			set
			{
				this.spriteSequence.CopyAssign(value);
			}
		}

		// Token: 0x06020E14 RID: 134676 RVA: 0x003090A7 File Offset: 0x003072A7
		public void SetSpriteSequence([Nullable(new byte[]
		{
			2,
			1
		})] TArray<ULGUISpriteData_BaseObject> value)
		{
			UUISpriteSequencePlayer.__SetSpriteSequence_Internal(base.NativePtr, (value ?? new TArray<ULGUISpriteData_BaseObject>()).NativePtr);
		}

		// Token: 0x06020E15 RID: 134677 RVA: 0x003090C3 File Offset: 0x003072C3
		public TArray<ULGUISpriteData_BaseObject> GetSpriteSequence()
		{
			return new TArray<ULGUISpriteData_BaseObject>(UUISpriteSequencePlayer.__GetSpriteSequence_Internal(base.NativePtr), null);
		}

		// Token: 0x06020E16 RID: 134678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpriteSequence_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020E17 RID: 134679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpriteSequence_Internal(IntPtr @this);

		// Token: 0x06020E18 RID: 134680 RVA: 0x003090D6 File Offset: 0x003072D6
		static UUISpriteSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteSequencePlayer");
		}

		// Token: 0x06020E19 RID: 134681 RVA: 0x003090E4 File Offset: 0x003072E4
		protected UUISpriteSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118FD RID: 71933
		public new const string __ObjectPath = "/Script/LGUI.UISpriteSequencePlayer";

		// Token: 0x040118FE RID: 71934
		private static IntPtr _ClassPtr;

		// Token: 0x040118FF RID: 71935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011900 RID: 71936
		internal static int __PropertyOffset_sprite;

		// Token: 0x04011901 RID: 71937
		internal static int __PropertyOffset_spriteSequence;

		// Token: 0x04011902 RID: 71938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUISpriteData_BaseObject> _spriteSequence;
	}
}
