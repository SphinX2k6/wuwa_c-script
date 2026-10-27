using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200089F RID: 2207
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BandwidthTestActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ABandwidthTestActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060078C2 RID: 30914 RVA: 0x000ACE82 File Offset: 0x000AB082
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABandwidthTestActor._ClassPtr;
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x000ACE90 File Offset: 0x000AB090
		public ABandwidthTestActor() : this(BuiltinUtils.AllocNativeUObject(ABandwidthTestActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x000ACEB8 File Offset: 0x000AB0B8
		public ABandwidthTestActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABandwidthTestActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x060078C5 RID: 30917 RVA: 0x000ACEEC File Offset: 0x000AB0EC
		// (set) Token: 0x060078C6 RID: 30918 RVA: 0x000ACF25 File Offset: 0x000AB125
		public FBandwidthTestGenerator BandwidthGenerator
		{
			get
			{
				base.FastCheckIsValid();
				FBandwidthTestGenerator result;
				if ((result = this._BandwidthGenerator) == null)
				{
					result = (this._BandwidthGenerator = new FBandwidthTestGenerator(base.NativePtr + (IntPtr)ABandwidthTestActor.__PropertyOffset_BandwidthGenerator, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBandwidthTestGenerator.StaticStruct(), base.NativePtr + (IntPtr)ABandwidthTestActor.__PropertyOffset_BandwidthGenerator, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x000ACF46 File Offset: 0x000AB146
		static ABandwidthTestActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BandwidthTestActor");
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x000ACF54 File Offset: 0x000AB154
		protected ABandwidthTestActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A00 RID: 14848
		public new const string __ObjectPath = "/Script/Engine.BandwidthTestActor";

		// Token: 0x04003A01 RID: 14849
		private static IntPtr _ClassPtr;

		// Token: 0x04003A02 RID: 14850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A03 RID: 14851
		internal static int __PropertyOffset_BandwidthGenerator;

		// Token: 0x04003A04 RID: 14852
		[Nullable(2)]
		private FBandwidthTestGenerator _BandwidthGenerator;
	}
}
