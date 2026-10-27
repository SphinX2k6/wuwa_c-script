using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E7 RID: 10727
	[UnrealObjectPath("/Script/UMG.UMGSequenceTickManager")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUMGSequenceTickManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BD6 RID: 162774 RVA: 0x003C943C File Offset: 0x003C763C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUMGSequenceTickManager._ClassPtr;
		}

		// Token: 0x06027BD7 RID: 162775 RVA: 0x003C9448 File Offset: 0x003C7648
		public UUMGSequenceTickManager() : this(BuiltinUtils.AllocNativeUObject(UUMGSequenceTickManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BD8 RID: 162776 RVA: 0x003C9470 File Offset: 0x003C7670
		[NullableContext(1)]
		public UUMGSequenceTickManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUMGSequenceTickManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700983E RID: 38974
		// (get) Token: 0x06027BD9 RID: 162777 RVA: 0x003C94A4 File Offset: 0x003C76A4
		// (set) Token: 0x06027BDA RID: 162778 RVA: 0x003C94DD File Offset: 0x003C76DD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TSet<TWeakObjectPtr<UUserWidget>> WeakUserWidgets
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TWeakObjectPtr<UUserWidget>> result;
				if ((result = this._WeakUserWidgets) == null)
				{
					result = (this._WeakUserWidgets = new TSet<TWeakObjectPtr<UUserWidget>>(base.NativePtr + (IntPtr)UUMGSequenceTickManager.__PropertyOffset_WeakUserWidgets, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.WeakUserWidgets.CopyAssign(value);
			}
		}

		// Token: 0x1700983F RID: 38975
		// (get) Token: 0x06027BDB RID: 162779 RVA: 0x003C94EB File Offset: 0x003C76EB
		// (set) Token: 0x06027BDC RID: 162780 RVA: 0x003C94FF File Offset: 0x003C76FF
		[Nullable(2)]
		public unsafe UMovieSceneEntitySystemLinker Linker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneEntitySystemLinker>(base.NativePtr / (IntPtr)sizeof(void*) + UUMGSequenceTickManager.__PropertyOffset_Linker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUMGSequenceTickManager.__PropertyOffset_Linker, value);
			}
		}

		// Token: 0x06027BDD RID: 162781 RVA: 0x003C9514 File Offset: 0x003C7714
		static UUMGSequenceTickManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UMGSequenceTickManager");
		}

		// Token: 0x06027BDE RID: 162782 RVA: 0x003C9522 File Offset: 0x003C7722
		protected UUMGSequenceTickManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C1E RID: 89118
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.UMGSequenceTickManager";

		// Token: 0x04015C1F RID: 89119
		private static IntPtr _ClassPtr;

		// Token: 0x04015C20 RID: 89120
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C21 RID: 89121
		internal static int __PropertyOffset_WeakUserWidgets;

		// Token: 0x04015C22 RID: 89122
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TWeakObjectPtr<UUserWidget>> _WeakUserWidgets;

		// Token: 0x04015C23 RID: 89123
		internal static int __PropertyOffset_Linker;
	}
}
