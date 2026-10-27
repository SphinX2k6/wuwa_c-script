using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001144 RID: 4420
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeGroupControl")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeGroupControl : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010287 RID: 66183 RVA: 0x0017CEE1 File Offset: 0x0017B0E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeGroupControl._ClassPtr;
		}

		// Token: 0x06010288 RID: 66184 RVA: 0x0017CEF0 File Offset: 0x0017B0F0
		public USoundNodeGroupControl() : this(BuiltinUtils.AllocNativeUObject(USoundNodeGroupControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010289 RID: 66185 RVA: 0x0017CF18 File Offset: 0x0017B118
		public USoundNodeGroupControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeGroupControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0601028A RID: 66186 RVA: 0x0017CF4C File Offset: 0x0017B14C
		// (set) Token: 0x0601028B RID: 66187 RVA: 0x0017CF85 File Offset: 0x0017B185
		public TArray<int> GroupSizes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._GroupSizes) == null)
				{
					result = (this._GroupSizes = new TArray<int>(base.NativePtr + (IntPtr)USoundNodeGroupControl.__PropertyOffset_GroupSizes, this));
				}
				return result;
			}
			set
			{
				this.GroupSizes.CopyAssign(value);
			}
		}

		// Token: 0x0601028C RID: 66188 RVA: 0x0017CF93 File Offset: 0x0017B193
		static USoundNodeGroupControl()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeGroupControl");
		}

		// Token: 0x0601028D RID: 66189 RVA: 0x0017CFA1 File Offset: 0x0017B1A1
		protected USoundNodeGroupControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B13 RID: 35603
		public new const string __ObjectPath = "/Script/Engine.SoundNodeGroupControl";

		// Token: 0x04008B14 RID: 35604
		private static IntPtr _ClassPtr;

		// Token: 0x04008B15 RID: 35605
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B16 RID: 35606
		internal static int __PropertyOffset_GroupSizes;

		// Token: 0x04008B17 RID: 35607
		[Nullable(2)]
		private TArray<int> _GroupSizes;
	}
}
