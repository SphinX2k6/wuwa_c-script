using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200113D RID: 4413
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeConcatenator")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeConcatenator : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010234 RID: 66100 RVA: 0x0017C707 File Offset: 0x0017A907
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeConcatenator._ClassPtr;
		}

		// Token: 0x06010235 RID: 66101 RVA: 0x0017C714 File Offset: 0x0017A914
		public USoundNodeConcatenator() : this(BuiltinUtils.AllocNativeUObject(USoundNodeConcatenator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010236 RID: 66102 RVA: 0x0017C73C File Offset: 0x0017A93C
		public USoundNodeConcatenator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeConcatenator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x06010237 RID: 66103 RVA: 0x0017C770 File Offset: 0x0017A970
		// (set) Token: 0x06010238 RID: 66104 RVA: 0x0017C7A9 File Offset: 0x0017A9A9
		public TArray<float> InputVolume
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._InputVolume) == null)
				{
					result = (this._InputVolume = new TArray<float>(base.NativePtr + (IntPtr)USoundNodeConcatenator.__PropertyOffset_InputVolume, this));
				}
				return result;
			}
			set
			{
				this.InputVolume.CopyAssign(value);
			}
		}

		// Token: 0x06010239 RID: 66105 RVA: 0x0017C7B7 File Offset: 0x0017A9B7
		static USoundNodeConcatenator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeConcatenator");
		}

		// Token: 0x0601023A RID: 66106 RVA: 0x0017C7C5 File Offset: 0x0017A9C5
		protected USoundNodeConcatenator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AE0 RID: 35552
		public new const string __ObjectPath = "/Script/Engine.SoundNodeConcatenator";

		// Token: 0x04008AE1 RID: 35553
		private static IntPtr _ClassPtr;

		// Token: 0x04008AE2 RID: 35554
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AE3 RID: 35555
		internal static int __PropertyOffset_InputVolume;

		// Token: 0x04008AE4 RID: 35556
		[Nullable(2)]
		private TArray<float> _InputVolume;
	}
}
