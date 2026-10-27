using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F4 RID: 2036
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimComposite")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UAnimComposite : UAnimCompositeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CB0 RID: 27824 RVA: 0x0009C719 File Offset: 0x0009A919
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimComposite._ClassPtr;
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x0009C728 File Offset: 0x0009A928
		public UAnimComposite() : this(BuiltinUtils.AllocNativeUObject(UAnimComposite.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x0009C750 File Offset: 0x0009A950
		public UAnimComposite(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimComposite.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06006CB3 RID: 27827 RVA: 0x0009C784 File Offset: 0x0009A984
		// (set) Token: 0x06006CB4 RID: 27828 RVA: 0x0009C7BD File Offset: 0x0009A9BD
		public FAnimTrack AnimationTrack
		{
			get
			{
				base.FastCheckIsValid();
				FAnimTrack result;
				if ((result = this._AnimationTrack) == null)
				{
					result = (this._AnimationTrack = new FAnimTrack(base.NativePtr + (IntPtr)UAnimComposite.__PropertyOffset_AnimationTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimTrack.StaticStruct(), base.NativePtr + (IntPtr)UAnimComposite.__PropertyOffset_AnimationTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x0009C7DE File Offset: 0x0009A9DE
		static UAnimComposite()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimComposite");
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x0009C7EC File Offset: 0x0009A9EC
		protected UAnimComposite(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400346C RID: 13420
		public new const string __ObjectPath = "/Script/Engine.AnimComposite";

		// Token: 0x0400346D RID: 13421
		private static IntPtr _ClassPtr;

		// Token: 0x0400346E RID: 13422
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400346F RID: 13423
		internal static int __PropertyOffset_AnimationTrack;

		// Token: 0x04003470 RID: 13424
		[Nullable(2)]
		private FAnimTrack _AnimationTrack;
	}
}
