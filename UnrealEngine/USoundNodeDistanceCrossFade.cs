using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001140 RID: 4416
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeDistanceCrossFade")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeDistanceCrossFade : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601024D RID: 66125 RVA: 0x0017C9B2 File Offset: 0x0017ABB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeDistanceCrossFade._ClassPtr;
		}

		// Token: 0x0601024E RID: 66126 RVA: 0x0017C9C0 File Offset: 0x0017ABC0
		public USoundNodeDistanceCrossFade() : this(BuiltinUtils.AllocNativeUObject(USoundNodeDistanceCrossFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601024F RID: 66127 RVA: 0x0017C9E8 File Offset: 0x0017ABE8
		public USoundNodeDistanceCrossFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeDistanceCrossFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x06010250 RID: 66128 RVA: 0x0017CA1C File Offset: 0x0017AC1C
		// (set) Token: 0x06010251 RID: 66129 RVA: 0x0017CA55 File Offset: 0x0017AC55
		public TArray<FDistanceDatum> CrossFadeInput
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDistanceDatum> result;
				if ((result = this._CrossFadeInput) == null)
				{
					result = (this._CrossFadeInput = new TArray<FDistanceDatum>(base.NativePtr + (IntPtr)USoundNodeDistanceCrossFade.__PropertyOffset_CrossFadeInput, this));
				}
				return result;
			}
			set
			{
				this.CrossFadeInput.CopyAssign(value);
			}
		}

		// Token: 0x06010252 RID: 66130 RVA: 0x0017CA63 File Offset: 0x0017AC63
		static USoundNodeDistanceCrossFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeDistanceCrossFade");
		}

		// Token: 0x06010253 RID: 66131 RVA: 0x0017CA71 File Offset: 0x0017AC71
		protected USoundNodeDistanceCrossFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AF1 RID: 35569
		public new const string __ObjectPath = "/Script/Engine.SoundNodeDistanceCrossFade";

		// Token: 0x04008AF2 RID: 35570
		private static IntPtr _ClassPtr;

		// Token: 0x04008AF3 RID: 35571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AF4 RID: 35572
		internal static int __PropertyOffset_CrossFadeInput;

		// Token: 0x04008AF5 RID: 35573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDistanceDatum> _CrossFadeInput;
	}
}
