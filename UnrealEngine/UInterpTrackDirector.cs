using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C8F RID: 3215
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackDirector")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UInterpTrackDirector : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A32A RID: 41770 RVA: 0x000E7D0A File Offset: 0x000E5F0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackDirector._ClassPtr;
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x000E7D18 File Offset: 0x000E5F18
		public UInterpTrackDirector() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackDirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x000E7D40 File Offset: 0x000E5F40
		public UInterpTrackDirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackDirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x000E7D74 File Offset: 0x000E5F74
		// (set) Token: 0x0600A32E RID: 41774 RVA: 0x000E7DAD File Offset: 0x000E5FAD
		public TArray<FDirectorTrackCut> CutTrack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDirectorTrackCut> result;
				if ((result = this._CutTrack) == null)
				{
					result = (this._CutTrack = new TArray<FDirectorTrackCut>(base.NativePtr + (IntPtr)UInterpTrackDirector.__PropertyOffset_CutTrack, this));
				}
				return result;
			}
			set
			{
				this.CutTrack.CopyAssign(value);
			}
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x000E7DBB File Offset: 0x000E5FBB
		// (set) Token: 0x0600A330 RID: 41776 RVA: 0x000E7DD4 File Offset: 0x000E5FD4
		public unsafe bool bSimulateCameraCutsOnClients
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackDirector.__PropertyOffset_bSimulateCameraCutsOnClients) & UInterpTrackDirector.__PropertyMask_bSimulateCameraCutsOnClients) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackDirector.__PropertyOffset_bSimulateCameraCutsOnClients) = ((*(base.NativePtr + (IntPtr)UInterpTrackDirector.__PropertyOffset_bSimulateCameraCutsOnClients) & ~UInterpTrackDirector.__PropertyMask_bSimulateCameraCutsOnClients) | (value ? UInterpTrackDirector.__PropertyMask_bSimulateCameraCutsOnClients : 0));
			}
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x000E7E04 File Offset: 0x000E6004
		static UInterpTrackDirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackDirector");
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x000E7E12 File Offset: 0x000E6012
		protected UInterpTrackDirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400599E RID: 22942
		public new const string __ObjectPath = "/Script/Engine.InterpTrackDirector";

		// Token: 0x0400599F RID: 22943
		private static IntPtr _ClassPtr;

		// Token: 0x040059A0 RID: 22944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059A1 RID: 22945
		internal static int __PropertyOffset_CutTrack;

		// Token: 0x040059A2 RID: 22946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDirectorTrackCut> _CutTrack;

		// Token: 0x040059A3 RID: 22947
		internal static int __PropertyOffset_bSimulateCameraCutsOnClients;

		// Token: 0x040059A4 RID: 22948
		internal static byte __PropertyMask_bSimulateCameraCutsOnClients;
	}
}
