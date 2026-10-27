using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F52 RID: 3922
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAttractorLine")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UParticleModuleAttractorLine : UParticleModuleAttractorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D383 RID: 54147 RVA: 0x001363A9 File Offset: 0x001345A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAttractorLine._ClassPtr;
		}

		// Token: 0x0600D384 RID: 54148 RVA: 0x001363B8 File Offset: 0x001345B8
		public UParticleModuleAttractorLine() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorLine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D385 RID: 54149 RVA: 0x001363E0 File Offset: 0x001345E0
		public UParticleModuleAttractorLine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorLine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600D386 RID: 54150 RVA: 0x00136413 File Offset: 0x00134613
		// (set) Token: 0x0600D387 RID: 54151 RVA: 0x00136427 File Offset: 0x00134627
		public unsafe FVector EndPoint0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_EndPoint0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_EndPoint0) = value;
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600D388 RID: 54152 RVA: 0x0013643C File Offset: 0x0013463C
		// (set) Token: 0x0600D389 RID: 54153 RVA: 0x00136450 File Offset: 0x00134650
		public unsafe FVector EndPoint1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_EndPoint1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_EndPoint1) = value;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x00136468 File Offset: 0x00134668
		// (set) Token: 0x0600D38B RID: 54155 RVA: 0x001364A1 File Offset: 0x001346A1
		public FRawDistributionFloat Range
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Range) == null)
				{
					result = (this._Range = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_Range, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_Range, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600D38C RID: 54156 RVA: 0x001364C4 File Offset: 0x001346C4
		// (set) Token: 0x0600D38D RID: 54157 RVA: 0x001364FD File Offset: 0x001346FD
		public FRawDistributionFloat Strength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Strength) == null)
				{
					result = (this._Strength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_Strength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorLine.__PropertyOffset_Strength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x0013651E File Offset: 0x0013471E
		static UParticleModuleAttractorLine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAttractorLine");
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x0013652C File Offset: 0x0013472C
		protected UParticleModuleAttractorLine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007195 RID: 29077
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAttractorLine";

		// Token: 0x04007196 RID: 29078
		private static IntPtr _ClassPtr;

		// Token: 0x04007197 RID: 29079
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007198 RID: 29080
		internal static int __PropertyOffset_EndPoint0;

		// Token: 0x04007199 RID: 29081
		internal static int __PropertyOffset_EndPoint1;

		// Token: 0x0400719A RID: 29082
		internal static int __PropertyOffset_Range;

		// Token: 0x0400719B RID: 29083
		[Nullable(2)]
		private FRawDistributionFloat _Range;

		// Token: 0x0400719C RID: 29084
		internal static int __PropertyOffset_Strength;

		// Token: 0x0400719D RID: 29085
		[Nullable(2)]
		private FRawDistributionFloat _Strength;
	}
}
