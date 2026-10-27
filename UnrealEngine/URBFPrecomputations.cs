using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001071 RID: 4209
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFPrecomputations")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class URBFPrecomputations : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EF80 RID: 61312 RVA: 0x001632C0 File Offset: 0x001614C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URBFPrecomputations._ClassPtr;
		}

		// Token: 0x0600EF81 RID: 61313 RVA: 0x001632CC File Offset: 0x001614CC
		public URBFPrecomputations() : this(BuiltinUtils.AllocNativeUObject(URBFPrecomputations.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EF82 RID: 61314 RVA: 0x001632F4 File Offset: 0x001614F4
		public URBFPrecomputations(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URBFPrecomputations.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600EF83 RID: 61315 RVA: 0x00163327 File Offset: 0x00161527
		// (set) Token: 0x0600EF84 RID: 61316 RVA: 0x0016333B File Offset: 0x0016153B
		public unsafe string LastSkeletonPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)URBFPrecomputations.__PropertyOffset_LastSkeletonPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)URBFPrecomputations.__PropertyOffset_LastSkeletonPath)), value);
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600EF85 RID: 61317 RVA: 0x00163350 File Offset: 0x00161550
		// (set) Token: 0x0600EF86 RID: 61318 RVA: 0x00163389 File Offset: 0x00161589
		public TMap<FName, FRBFPrecomputation> Precomputations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FRBFPrecomputation> result;
				if ((result = this._Precomputations) == null)
				{
					result = (this._Precomputations = new TMap<FName, FRBFPrecomputation>(base.NativePtr + (IntPtr)URBFPrecomputations.__PropertyOffset_Precomputations, this));
				}
				return result;
			}
			set
			{
				this.Precomputations.CopyAssign(value);
			}
		}

		// Token: 0x0600EF87 RID: 61319 RVA: 0x00163397 File Offset: 0x00161597
		static URBFPrecomputations()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RBFPrecomputations");
		}

		// Token: 0x0600EF88 RID: 61320 RVA: 0x001633A5 File Offset: 0x001615A5
		protected URBFPrecomputations(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008196 RID: 33174
		public new const string __ObjectPath = "/Script/Engine.RBFPrecomputations";

		// Token: 0x04008197 RID: 33175
		private static IntPtr _ClassPtr;

		// Token: 0x04008198 RID: 33176
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008199 RID: 33177
		internal static int __PropertyOffset_LastSkeletonPath;

		// Token: 0x0400819A RID: 33178
		internal static int __PropertyOffset_Precomputations;

		// Token: 0x0400819B RID: 33179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FRBFPrecomputation> _Precomputations;
	}
}
