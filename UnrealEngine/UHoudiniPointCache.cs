using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001515 RID: 5397
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniNiagara.HoudiniPointCache")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UHoudiniPointCache : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013A1A RID: 80410 RVA: 0x001CD590 File Offset: 0x001CB790
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniPointCache._ClassPtr;
		}

		// Token: 0x06013A1B RID: 80411 RVA: 0x001CD59C File Offset: 0x001CB79C
		public UHoudiniPointCache() : this(BuiltinUtils.AllocNativeUObject(UHoudiniPointCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013A1C RID: 80412 RVA: 0x001CD5C4 File Offset: 0x001CB7C4
		public UHoudiniPointCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniPointCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x06013A1D RID: 80413 RVA: 0x001CD5F7 File Offset: 0x001CB7F7
		// (set) Token: 0x06013A1E RID: 80414 RVA: 0x001CD60B File Offset: 0x001CB80B
		public unsafe string FileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPointCache.__PropertyOffset_FileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPointCache.__PropertyOffset_FileName)), value);
			}
		}

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x06013A1F RID: 80415 RVA: 0x001CD620 File Offset: 0x001CB820
		// (set) Token: 0x06013A20 RID: 80416 RVA: 0x001CD630 File Offset: 0x001CB830
		public unsafe int NumberOfSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfSamples) = value;
			}
		}

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x06013A21 RID: 80417 RVA: 0x001CD641 File Offset: 0x001CB841
		// (set) Token: 0x06013A22 RID: 80418 RVA: 0x001CD651 File Offset: 0x001CB851
		public unsafe int NumberOfAttributes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfAttributes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfAttributes) = value;
			}
		}

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x06013A23 RID: 80419 RVA: 0x001CD662 File Offset: 0x001CB862
		// (set) Token: 0x06013A24 RID: 80420 RVA: 0x001CD672 File Offset: 0x001CB872
		public unsafe int NumberOfPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfPoints) = value;
			}
		}

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x06013A25 RID: 80421 RVA: 0x001CD683 File Offset: 0x001CB883
		// (set) Token: 0x06013A26 RID: 80422 RVA: 0x001CD693 File Offset: 0x001CB893
		public unsafe int NumberOfFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_NumberOfFrames) = value;
			}
		}

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x06013A27 RID: 80423 RVA: 0x001CD6A4 File Offset: 0x001CB8A4
		// (set) Token: 0x06013A28 RID: 80424 RVA: 0x001CD6B4 File Offset: 0x001CB8B4
		public unsafe float FirstFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_FirstFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_FirstFrame) = value;
			}
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x06013A29 RID: 80425 RVA: 0x001CD6C5 File Offset: 0x001CB8C5
		// (set) Token: 0x06013A2A RID: 80426 RVA: 0x001CD6D5 File Offset: 0x001CB8D5
		public unsafe float LastFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_LastFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_LastFrame) = value;
			}
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x06013A2B RID: 80427 RVA: 0x001CD6E6 File Offset: 0x001CB8E6
		// (set) Token: 0x06013A2C RID: 80428 RVA: 0x001CD6F6 File Offset: 0x001CB8F6
		public unsafe float MinSampleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_MinSampleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_MinSampleTime) = value;
			}
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06013A2D RID: 80429 RVA: 0x001CD707 File Offset: 0x001CB907
		// (set) Token: 0x06013A2E RID: 80430 RVA: 0x001CD717 File Offset: 0x001CB917
		public unsafe float MaxSampleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_MaxSampleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_MaxSampleTime) = value;
			}
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x06013A2F RID: 80431 RVA: 0x001CD728 File Offset: 0x001CB928
		// (set) Token: 0x06013A30 RID: 80432 RVA: 0x001CD73C File Offset: 0x001CB93C
		public unsafe string SourceCSVTitleRow
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPointCache.__PropertyOffset_SourceCSVTitleRow)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniPointCache.__PropertyOffset_SourceCSVTitleRow)), value);
			}
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x06013A31 RID: 80433 RVA: 0x001CD754 File Offset: 0x001CB954
		// (set) Token: 0x06013A32 RID: 80434 RVA: 0x001CD78D File Offset: 0x001CB98D
		public TArray<string> AttributeArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AttributeArray) == null)
				{
					result = (this._AttributeArray = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_AttributeArray, this));
				}
				return result;
			}
			set
			{
				this.AttributeArray.CopyAssign(value);
			}
		}

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x06013A33 RID: 80435 RVA: 0x001CD79C File Offset: 0x001CB99C
		// (set) Token: 0x06013A34 RID: 80436 RVA: 0x001CD7D5 File Offset: 0x001CB9D5
		public TArray<float> FloatSampleData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FloatSampleData) == null)
				{
					result = (this._FloatSampleData = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_FloatSampleData, this));
				}
				return result;
			}
			set
			{
				this.FloatSampleData.CopyAssign(value);
			}
		}

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x06013A35 RID: 80437 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
		// (set) Token: 0x06013A36 RID: 80438 RVA: 0x001CD81D File Offset: 0x001CBA1D
		public TArray<float> SpawnTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._SpawnTimes) == null)
				{
					result = (this._SpawnTimes = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_SpawnTimes, this));
				}
				return result;
			}
			set
			{
				this.SpawnTimes.CopyAssign(value);
			}
		}

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x06013A37 RID: 80439 RVA: 0x001CD82C File Offset: 0x001CBA2C
		// (set) Token: 0x06013A38 RID: 80440 RVA: 0x001CD865 File Offset: 0x001CBA65
		public TArray<float> LifeValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LifeValues) == null)
				{
					result = (this._LifeValues = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_LifeValues, this));
				}
				return result;
			}
			set
			{
				this.LifeValues.CopyAssign(value);
			}
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x06013A39 RID: 80441 RVA: 0x001CD874 File Offset: 0x001CBA74
		// (set) Token: 0x06013A3A RID: 80442 RVA: 0x001CD8AD File Offset: 0x001CBAAD
		public TArray<int> PointTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PointTypes) == null)
				{
					result = (this._PointTypes = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_PointTypes, this));
				}
				return result;
			}
			set
			{
				this.PointTypes.CopyAssign(value);
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x06013A3B RID: 80443 RVA: 0x001CD8BC File Offset: 0x001CBABC
		// (set) Token: 0x06013A3C RID: 80444 RVA: 0x001CD8F5 File Offset: 0x001CBAF5
		public TArray<int> SpecialAttributeIndexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SpecialAttributeIndexes) == null)
				{
					result = (this._SpecialAttributeIndexes = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_SpecialAttributeIndexes, this));
				}
				return result;
			}
			set
			{
				this.SpecialAttributeIndexes.CopyAssign(value);
			}
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x06013A3D RID: 80445 RVA: 0x001CD904 File Offset: 0x001CBB04
		// (set) Token: 0x06013A3E RID: 80446 RVA: 0x001CD93D File Offset: 0x001CBB3D
		public TArray<FPointIndexes> PointValueIndexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPointIndexes> result;
				if ((result = this._PointValueIndexes) == null)
				{
					result = (this._PointValueIndexes = new TArray<FPointIndexes>(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_PointValueIndexes, this));
				}
				return result;
			}
			set
			{
				this.PointValueIndexes.CopyAssign(value);
			}
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x06013A3F RID: 80447 RVA: 0x001CD94B File Offset: 0x001CBB4B
		// (set) Token: 0x06013A40 RID: 80448 RVA: 0x001CD95B File Offset: 0x001CBB5B
		public unsafe bool UseCustomCSVTitleRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_UseCustomCSVTitleRow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_UseCustomCSVTitleRow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x06013A41 RID: 80449 RVA: 0x001CD96C File Offset: 0x001CBB6C
		// (set) Token: 0x06013A42 RID: 80450 RVA: 0x001CD97C File Offset: 0x001CBB7C
		public unsafe EHoudiniPointCacheFileType FileType
		{
			get
			{
				return (EHoudiniPointCacheFileType)(*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_FileType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniPointCache.__PropertyOffset_FileType) = (byte)value;
			}
		}

		// Token: 0x06013A43 RID: 80451 RVA: 0x001CD98D File Offset: 0x001CBB8D
		public void SetUseCustomCSVTitleRow(bool bInUseCustomCSVTitleRow)
		{
			UHoudiniPointCache.__SetUseCustomCSVTitleRow_Internal(base.NativePtr, bInUseCustomCSVTitleRow);
		}

		// Token: 0x06013A44 RID: 80452 RVA: 0x001CD99C File Offset: 0x001CBB9C
		public unsafe bool GetVelocityValue(in int sampleIndex, ref FVector value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetVelocityValue_Internal(base.NativePtr, sampleIndex, ref value);
				}
			}
		}

		// Token: 0x06013A45 RID: 80453 RVA: 0x001CD9C0 File Offset: 0x001CBBC0
		public unsafe bool GetVectorValueForString(in int sampleIndex, string Attribute, ref FVector value, in bool DoSwap = true, in bool DoScale = true)
		{
			FString fstring = FString.AllocTemp(Attribute);
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &DoSwap)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &DoScale)
						{
							void* ptr8 = (void*)ptr7;
							bool result = UHoudiniPointCache.__GetVectorValueForString_Internal(base.NativePtr, sampleIndex, fstring, ref value, DoSwap, DoScale);
							FString.NativeDestruct(&fstring, 1);
							return result;
						}
					}
				}
			}
		}

		// Token: 0x06013A46 RID: 80454 RVA: 0x001CDA10 File Offset: 0x001CBC10
		public unsafe bool GetVectorValue(in int sampleIndex, in int attrIndex, ref FVector value, in bool DoSwap = true, in bool DoScale = true)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &attrIndex)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &value)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &DoSwap)
						{
							void* ptr8 = (void*)ptr7;
							fixed (bool* ptr9 = &DoScale)
							{
								void* ptr10 = (void*)ptr9;
								return UHoudiniPointCache.__GetVectorValue_Internal(base.NativePtr, sampleIndex, attrIndex, ref value, DoSwap, DoScale);
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A47 RID: 80455 RVA: 0x001CDA58 File Offset: 0x001CBC58
		public unsafe bool GetVector4ValueForString(in int sampleIndex, string Attribute, ref FVector4 value)
		{
			FString fstring = FString.AllocTemp(Attribute);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = value;
			fixed (int* ptr2 = &sampleIndex)
			{
				void* ptr3 = (void*)ptr2;
				bool result = UHoudiniPointCache.__GetVector4ValueForString_Internal(base.NativePtr, sampleIndex, fstring, ref ptr);
				FString.NativeDestruct(&fstring, 1);
				value = ptr;
				return result;
			}
		}

		// Token: 0x06013A48 RID: 80456 RVA: 0x001CDAB4 File Offset: 0x001CBCB4
		public unsafe bool GetVector4Value(in int sampleIndex, in int attrIndex, ref FVector4 value)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = value;
			fixed (int* ptr2 = &sampleIndex)
			{
				void* ptr3 = (void*)ptr2;
				fixed (int* ptr4 = &attrIndex)
				{
					void* ptr5 = (void*)ptr4;
					bool result = UHoudiniPointCache.__GetVector4Value_Internal(base.NativePtr, sampleIndex, attrIndex, ref ptr);
					value = ptr;
					return result;
				}
			}
		}

		// Token: 0x06013A49 RID: 80457 RVA: 0x001CDB03 File Offset: 0x001CBD03
		public bool GetUseCustomCSVTitleRow()
		{
			return UHoudiniPointCache.__GetUseCustomCSVTitleRow_Internal(base.NativePtr);
		}

		// Token: 0x06013A4A RID: 80458 RVA: 0x001CDB10 File Offset: 0x001CBD10
		public unsafe bool GetTimeValue(in int sampleIndex, ref float value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetTimeValue_Internal(base.NativePtr, sampleIndex, ref value);
				}
			}
		}

		// Token: 0x06013A4B RID: 80459 RVA: 0x001CDB34 File Offset: 0x001CBD34
		public TArray<int> GetSpecialAttributeIndexes()
		{
			return new TArray<int>(UHoudiniPointCache.__GetSpecialAttributeIndexes_Internal(base.NativePtr), null);
		}

		// Token: 0x06013A4C RID: 80460 RVA: 0x001CDB47 File Offset: 0x001CBD47
		public TArray<float> GetSpawnTimes()
		{
			return new TArray<float>(UHoudiniPointCache.__GetSpawnTimes_Internal(base.NativePtr), null);
		}

		// Token: 0x06013A4D RID: 80461 RVA: 0x001CDB5C File Offset: 0x001CBD5C
		public unsafe bool GetSampleIndexesForPointAtTime(in int PointID, in float desiredTime, ref int PrevSampleIndex, ref int NextSampleIndex, ref float PrevWeight)
		{
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &desiredTime)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &PrevSampleIndex)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &NextSampleIndex)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &PrevWeight)
							{
								void* ptr10 = (void*)ptr9;
								return UHoudiniPointCache.__GetSampleIndexesForPointAtTime_Internal(base.NativePtr, PointID, desiredTime, ref PrevSampleIndex, ref NextSampleIndex, ref PrevWeight);
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A4E RID: 80462 RVA: 0x001CDBA4 File Offset: 0x001CBDA4
		public unsafe bool GetQuatValueForString(in int sampleIndex, string Attribute, ref FQuat value, in bool DoHoudiniToUnrealConversion = true)
		{
			FString fstring = FString.AllocTemp(Attribute);
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = value;
			fixed (int* ptr2 = &sampleIndex)
			{
				void* ptr3 = (void*)ptr2;
				fixed (bool* ptr4 = &DoHoudiniToUnrealConversion)
				{
					void* ptr5 = (void*)ptr4;
					bool result = UHoudiniPointCache.__GetQuatValueForString_Internal(base.NativePtr, sampleIndex, fstring, ref ptr, DoHoudiniToUnrealConversion);
					FString.NativeDestruct(&fstring, 1);
					value = ptr;
					return result;
				}
			}
		}

		// Token: 0x06013A4F RID: 80463 RVA: 0x001CDC0C File Offset: 0x001CBE0C
		public unsafe bool GetQuatValue(in int sampleIndex, in int attrIndex, ref FQuat value, in bool DoHoudiniToUnrealConversion = true)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = value;
			fixed (int* ptr2 = &sampleIndex)
			{
				void* ptr3 = (void*)ptr2;
				fixed (int* ptr4 = &attrIndex)
				{
					void* ptr5 = (void*)ptr4;
					fixed (bool* ptr6 = &DoHoudiniToUnrealConversion)
					{
						void* ptr7 = (void*)ptr6;
						bool result = UHoudiniPointCache.__GetQuatValue_Internal(base.NativePtr, sampleIndex, attrIndex, ref ptr, DoHoudiniToUnrealConversion);
						value = ptr;
						return result;
					}
				}
			}
		}

		// Token: 0x06013A50 RID: 80464 RVA: 0x001CDC68 File Offset: 0x001CBE68
		public unsafe bool GetPositionValue(in int sampleIndex, ref FVector value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetPositionValue_Internal(base.NativePtr, sampleIndex, ref value);
				}
			}
		}

		// Token: 0x06013A51 RID: 80465 RVA: 0x001CDC8C File Offset: 0x001CBE8C
		public unsafe bool GetPointVectorValueAtTimeForString(int PointID, string Attribute, float desiredTime, ref FVector Vector, bool DoSwap, bool DoScale)
		{
			FString fstring = FString.AllocTemp(Attribute);
			fixed (FVector* ptr = &Vector)
			{
				void* ptr2 = (void*)ptr;
				bool result = UHoudiniPointCache.__GetPointVectorValueAtTimeForString_Internal(base.NativePtr, PointID, fstring, desiredTime, ref Vector, DoSwap, DoScale);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06013A52 RID: 80466 RVA: 0x001CDCC4 File Offset: 0x001CBEC4
		public unsafe bool GetPointVectorValueAtTime(int PointID, int AttributeIndex, float desiredTime, ref FVector Vector, bool DoSwap, bool DoScale)
		{
			fixed (FVector* ptr = &Vector)
			{
				void* ptr2 = (void*)ptr;
				return UHoudiniPointCache.__GetPointVectorValueAtTime_Internal(base.NativePtr, PointID, AttributeIndex, desiredTime, ref Vector, DoSwap, DoScale);
			}
		}

		// Token: 0x06013A53 RID: 80467 RVA: 0x001CDCEC File Offset: 0x001CBEEC
		public unsafe bool GetPointVector4ValueAtTimeForString(int PointID, string Attribute, float desiredTime, ref FVector4 Vector)
		{
			FString fstring = FString.AllocTemp(Attribute);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Vector;
			bool result = UHoudiniPointCache.__GetPointVector4ValueAtTimeForString_Internal(base.NativePtr, PointID, fstring, desiredTime, ref ptr);
			FString.NativeDestruct(&fstring, 1);
			Vector = ptr;
			return result;
		}

		// Token: 0x06013A54 RID: 80468 RVA: 0x001CDD44 File Offset: 0x001CBF44
		public unsafe bool GetPointVector4ValueAtTime(int PointID, int AttributeIndex, float desiredTime, ref FVector4 Vector)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Vector;
			bool result = UHoudiniPointCache.__GetPointVector4ValueAtTime_Internal(base.NativePtr, PointID, AttributeIndex, desiredTime, ref ptr);
			Vector = ptr;
			return result;
		}

		// Token: 0x06013A55 RID: 80469 RVA: 0x001CDD8A File Offset: 0x001CBF8A
		public TArray<FPointIndexes> GetPointValueIndexes()
		{
			return new TArray<FPointIndexes>(UHoudiniPointCache.__GetPointValueIndexes_Internal(base.NativePtr), null);
		}

		// Token: 0x06013A56 RID: 80470 RVA: 0x001CDDA0 File Offset: 0x001CBFA0
		public unsafe bool GetPointValueAtTimeForString(in int PointID, string Attribute, in float desiredTime, ref float Value)
		{
			FString fstring = FString.AllocTemp(Attribute);
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &desiredTime)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Value)
					{
						void* ptr6 = (void*)ptr5;
						bool result = UHoudiniPointCache.__GetPointValueAtTimeForString_Internal(base.NativePtr, PointID, fstring, desiredTime, ref Value);
						FString.NativeDestruct(&fstring, 1);
						return result;
					}
				}
			}
		}

		// Token: 0x06013A57 RID: 80471 RVA: 0x001CDDE4 File Offset: 0x001CBFE4
		public unsafe bool GetPointValueAtTime(in int PointID, in int AttributeIndex, in float desiredTime, ref float Value)
		{
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &AttributeIndex)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &desiredTime)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &Value)
						{
							void* ptr8 = (void*)ptr7;
							return UHoudiniPointCache.__GetPointValueAtTime_Internal(base.NativePtr, PointID, AttributeIndex, desiredTime, ref Value);
						}
					}
				}
			}
		}

		// Token: 0x06013A58 RID: 80472 RVA: 0x001CDE1E File Offset: 0x001CC01E
		public TArray<int> GetPointTypes()
		{
			return new TArray<int>(UHoudiniPointCache.__GetPointTypes_Internal(base.NativePtr), null);
		}

		// Token: 0x06013A59 RID: 80473 RVA: 0x001CDE34 File Offset: 0x001CC034
		public unsafe bool GetPointType(in int PointID, ref int Value)
		{
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &Value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetPointType_Internal(base.NativePtr, PointID, ref Value);
				}
			}
		}

		// Token: 0x06013A5A RID: 80474 RVA: 0x001CDE58 File Offset: 0x001CC058
		public unsafe bool GetPointQuatValueAtTimeForString(int PointID, string Attribute, float desiredTime, ref FQuat Quat, bool DoHoudiniToUnrealConversion = true)
		{
			FString fstring = FString.AllocTemp(Attribute);
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Quat;
			bool result = UHoudiniPointCache.__GetPointQuatValueAtTimeForString_Internal(base.NativePtr, PointID, fstring, desiredTime, ref ptr, DoHoudiniToUnrealConversion);
			FString.NativeDestruct(&fstring, 1);
			Quat = ptr;
			return result;
		}

		// Token: 0x06013A5B RID: 80475 RVA: 0x001CDEB4 File Offset: 0x001CC0B4
		public unsafe bool GetPointQuatValueAtTime(int PointID, int AttributeIndex, float desiredTime, ref FQuat Quat, bool DoHoudiniToUnrealConversion = true)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Quat;
			bool result = UHoudiniPointCache.__GetPointQuatValueAtTime_Internal(base.NativePtr, PointID, AttributeIndex, desiredTime, ref ptr, DoHoudiniToUnrealConversion);
			Quat = ptr;
			return result;
		}

		// Token: 0x06013A5C RID: 80476 RVA: 0x001CDEFC File Offset: 0x001CC0FC
		public unsafe bool GetPointPositionAtTime(in int PointID, in float desiredTime, ref FVector Vector)
		{
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &desiredTime)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Vector)
					{
						void* ptr6 = (void*)ptr5;
						return UHoudiniPointCache.__GetPointPositionAtTime_Internal(base.NativePtr, PointID, desiredTime, ref Vector);
					}
				}
			}
		}

		// Token: 0x06013A5D RID: 80477 RVA: 0x001CDF2C File Offset: 0x001CC12C
		public unsafe bool GetPointLifeAtTime(in int PointID, in float DesiredTime, ref float Value)
		{
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &DesiredTime)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Value)
					{
						void* ptr6 = (void*)ptr5;
						return UHoudiniPointCache.__GetPointLifeAtTime_Internal(base.NativePtr, PointID, DesiredTime, ref Value);
					}
				}
			}
		}

		// Token: 0x06013A5E RID: 80478 RVA: 0x001CDF5C File Offset: 0x001CC15C
		public unsafe bool GetPointLife(in int PointID, ref float Value)
		{
			fixed (int* ptr = &PointID)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &Value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetPointLife_Internal(base.NativePtr, PointID, ref Value);
				}
			}
		}

		// Token: 0x06013A5F RID: 80479 RVA: 0x001CDF80 File Offset: 0x001CC180
		public unsafe bool GetPointInt32ValueAtTime(int PointID, int AttributeIndex, float desiredTime, ref int Value)
		{
			fixed (int* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				return UHoudiniPointCache.__GetPointInt32ValueAtTime_Internal(base.NativePtr, PointID, AttributeIndex, desiredTime, ref Value);
			}
		}

		// Token: 0x06013A60 RID: 80480 RVA: 0x001CDFA4 File Offset: 0x001CC1A4
		public unsafe bool GetPointIDsToSpawnAtTime(in float desiredTime, ref int MinID, ref int MaxID, ref int Count, ref int LastSpawnedPointID, ref float LastSpawnTime, ref float LastSpawnTimeRequest)
		{
			fixed (float* ptr = &desiredTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &MinID)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &MaxID)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &Count)
						{
							void* ptr8 = (void*)ptr7;
							fixed (int* ptr9 = &LastSpawnedPointID)
							{
								void* ptr10 = (void*)ptr9;
								fixed (float* ptr11 = &LastSpawnTime)
								{
									void* ptr12 = (void*)ptr11;
									fixed (float* ptr13 = &LastSpawnTimeRequest)
									{
										void* ptr14 = (void*)ptr13;
										return UHoudiniPointCache.__GetPointIDsToSpawnAtTime_Internal(base.NativePtr, desiredTime, ref MinID, ref MaxID, ref Count, ref LastSpawnedPointID, ref LastSpawnTime, ref LastSpawnTimeRequest);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013A61 RID: 80481 RVA: 0x001CE000 File Offset: 0x001CC200
		public unsafe bool GetPointFloatValueAtTime(int PointID, int AttributeIndex, float desiredTime, ref float Value)
		{
			fixed (float* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				return UHoudiniPointCache.__GetPointFloatValueAtTime_Internal(base.NativePtr, PointID, AttributeIndex, desiredTime, ref Value);
			}
		}

		// Token: 0x06013A62 RID: 80482 RVA: 0x001CE023 File Offset: 0x001CC223
		public int GetNumberOfSamples()
		{
			return UHoudiniPointCache.__GetNumberOfSamples_Internal(base.NativePtr);
		}

		// Token: 0x06013A63 RID: 80483 RVA: 0x001CE030 File Offset: 0x001CC230
		public int GetNumberOfPoints()
		{
			return UHoudiniPointCache.__GetNumberOfPoints_Internal(base.NativePtr);
		}

		// Token: 0x06013A64 RID: 80484 RVA: 0x001CE03D File Offset: 0x001CC23D
		public int GetNumberOfAttributes()
		{
			return UHoudiniPointCache.__GetNumberOfAttributes_Internal(base.NativePtr);
		}

		// Token: 0x06013A65 RID: 80485 RVA: 0x001CE04C File Offset: 0x001CC24C
		public unsafe bool GetNormalValue(in int sampleIndex, ref FVector value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetNormalValue_Internal(base.NativePtr, sampleIndex, ref value);
				}
			}
		}

		// Token: 0x06013A66 RID: 80486 RVA: 0x001CE070 File Offset: 0x001CC270
		public TArray<float> GetLifeValues()
		{
			return new TArray<float>(UHoudiniPointCache.__GetLifeValues_Internal(base.NativePtr), null);
		}

		// Token: 0x06013A67 RID: 80487 RVA: 0x001CE084 File Offset: 0x001CC284
		public unsafe bool GetLastSampleIndexAtTime(in float desiredTime, ref int lastSampleIndex)
		{
			fixed (float* ptr = &desiredTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &lastSampleIndex)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetLastSampleIndexAtTime_Internal(base.NativePtr, desiredTime, ref lastSampleIndex);
				}
			}
		}

		// Token: 0x06013A68 RID: 80488 RVA: 0x001CE0A8 File Offset: 0x001CC2A8
		public unsafe bool GetLastPointIDToSpawnAtTime(in float time, ref int lastID)
		{
			fixed (float* ptr = &time)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &lastID)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetLastPointIDToSpawnAtTime_Internal(base.NativePtr, time, ref lastID);
				}
			}
		}

		// Token: 0x06013A69 RID: 80489 RVA: 0x001CE0CC File Offset: 0x001CC2CC
		public unsafe bool GetImpulseValue(in int sampleIndex, ref float value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetImpulseValue_Internal(base.NativePtr, sampleIndex, ref value);
				}
			}
		}

		// Token: 0x06013A6A RID: 80490 RVA: 0x001CE0F0 File Offset: 0x001CC2F0
		public unsafe bool GetFloatValueForString(in int sampleIndex, string Attribute, ref float value)
		{
			FString fstring = FString.AllocTemp(Attribute);
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					bool result = UHoudiniPointCache.__GetFloatValueForString_Internal(base.NativePtr, sampleIndex, fstring, ref value);
					FString.NativeDestruct(&fstring, 1);
					return result;
				}
			}
		}

		// Token: 0x06013A6B RID: 80491 RVA: 0x001CE128 File Offset: 0x001CC328
		public unsafe bool GetFloatValue(in int sampleIndex, in int attrIndex, ref float value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &attrIndex)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &value)
					{
						void* ptr6 = (void*)ptr5;
						return UHoudiniPointCache.__GetFloatValue_Internal(base.NativePtr, sampleIndex, attrIndex, ref value);
					}
				}
			}
		}

		// Token: 0x06013A6C RID: 80492 RVA: 0x001CE156 File Offset: 0x001CC356
		public TArray<float> GetFloatSampleData()
		{
			return new TArray<float>(UHoudiniPointCache.__GetFloatSampleData_Internal(base.NativePtr), null);
		}

		// Token: 0x06013A6D RID: 80493 RVA: 0x001CE16C File Offset: 0x001CC36C
		public unsafe bool GetColorValue(in int sampleIndex, ref FLinearColor value)
		{
			fixed (int* ptr = &sampleIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (FLinearColor* ptr3 = &value)
				{
					void* ptr4 = (void*)ptr3;
					return UHoudiniPointCache.__GetColorValue_Internal(base.NativePtr, sampleIndex, ref value);
				}
			}
		}

		// Token: 0x06013A6E RID: 80494 RVA: 0x001CE190 File Offset: 0x001CC390
		public unsafe static bool GetAttributeIndexInArrayFromString(string InAttribute, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InAttributeArray, ref int OutAttributeIndex)
		{
			FString fstring = FString.AllocTemp(InAttribute);
			fixed (int* ptr = &OutAttributeIndex)
			{
				void* ptr2 = (void*)ptr;
				bool result = UHoudiniPointCache.__GetAttributeIndexInArrayFromString_Internal(fstring, (InAttributeArray ?? new TArray<string>()).NativePtr, ref OutAttributeIndex);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06013A6F RID: 80495 RVA: 0x001CE1CC File Offset: 0x001CC3CC
		public unsafe bool GetAttributeIndexFromString(string Attribute, ref int AttributeIndex)
		{
			FString fstring = FString.AllocTemp(Attribute);
			fixed (int* ptr = &AttributeIndex)
			{
				void* ptr2 = (void*)ptr;
				bool result = UHoudiniPointCache.__GetAttributeIndexFromString_Internal(base.NativePtr, fstring, ref AttributeIndex);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06013A70 RID: 80496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomCSVTitleRow_Internal(IntPtr @this, bool bInUseCustomCSVTitleRow);

		// Token: 0x06013A71 RID: 80497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVelocityValue_Internal(IntPtr @this, in int sampleIndex, ref FVector value);

		// Token: 0x06013A72 RID: 80498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVectorValueForString_Internal(IntPtr @this, in int sampleIndex, in FString Attribute, ref FVector value, in bool DoSwap, in bool DoScale);

		// Token: 0x06013A73 RID: 80499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVectorValue_Internal(IntPtr @this, in int sampleIndex, in int attrIndex, ref FVector value, in bool DoSwap, in bool DoScale);

		// Token: 0x06013A74 RID: 80500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVector4ValueForString_Internal(IntPtr @this, in int sampleIndex, in FString Attribute, ref FVector4 value);

		// Token: 0x06013A75 RID: 80501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVector4Value_Internal(IntPtr @this, in int sampleIndex, in int attrIndex, ref FVector4 value);

		// Token: 0x06013A76 RID: 80502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseCustomCSVTitleRow_Internal(IntPtr @this);

		// Token: 0x06013A77 RID: 80503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTimeValue_Internal(IntPtr @this, in int sampleIndex, ref float value);

		// Token: 0x06013A78 RID: 80504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpecialAttributeIndexes_Internal(IntPtr @this);

		// Token: 0x06013A79 RID: 80505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpawnTimes_Internal(IntPtr @this);

		// Token: 0x06013A7A RID: 80506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSampleIndexesForPointAtTime_Internal(IntPtr @this, in int PointID, in float desiredTime, ref int PrevSampleIndex, ref int NextSampleIndex, ref float PrevWeight);

		// Token: 0x06013A7B RID: 80507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetQuatValueForString_Internal(IntPtr @this, in int sampleIndex, in FString Attribute, ref FQuat value, in bool DoHoudiniToUnrealConversion);

		// Token: 0x06013A7C RID: 80508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetQuatValue_Internal(IntPtr @this, in int sampleIndex, in int attrIndex, ref FQuat value, in bool DoHoudiniToUnrealConversion);

		// Token: 0x06013A7D RID: 80509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPositionValue_Internal(IntPtr @this, in int sampleIndex, ref FVector value);

		// Token: 0x06013A7E RID: 80510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointVectorValueAtTimeForString_Internal(IntPtr @this, int PointID, in FString Attribute, float desiredTime, ref FVector Vector, bool DoSwap, bool DoScale);

		// Token: 0x06013A7F RID: 80511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointVectorValueAtTime_Internal(IntPtr @this, int PointID, int AttributeIndex, float desiredTime, ref FVector Vector, bool DoSwap, bool DoScale);

		// Token: 0x06013A80 RID: 80512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointVector4ValueAtTimeForString_Internal(IntPtr @this, int PointID, in FString Attribute, float desiredTime, ref FVector4 Vector);

		// Token: 0x06013A81 RID: 80513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointVector4ValueAtTime_Internal(IntPtr @this, int PointID, int AttributeIndex, float desiredTime, ref FVector4 Vector);

		// Token: 0x06013A82 RID: 80514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointValueIndexes_Internal(IntPtr @this);

		// Token: 0x06013A83 RID: 80515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointValueAtTimeForString_Internal(IntPtr @this, in int PointID, in FString Attribute, in float desiredTime, ref float Value);

		// Token: 0x06013A84 RID: 80516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointValueAtTime_Internal(IntPtr @this, in int PointID, in int AttributeIndex, in float desiredTime, ref float Value);

		// Token: 0x06013A85 RID: 80517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointTypes_Internal(IntPtr @this);

		// Token: 0x06013A86 RID: 80518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointType_Internal(IntPtr @this, in int PointID, ref int Value);

		// Token: 0x06013A87 RID: 80519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointQuatValueAtTimeForString_Internal(IntPtr @this, int PointID, in FString Attribute, float desiredTime, ref FQuat Quat, bool DoHoudiniToUnrealConversion);

		// Token: 0x06013A88 RID: 80520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointQuatValueAtTime_Internal(IntPtr @this, int PointID, int AttributeIndex, float desiredTime, ref FQuat Quat, bool DoHoudiniToUnrealConversion);

		// Token: 0x06013A89 RID: 80521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointPositionAtTime_Internal(IntPtr @this, in int PointID, in float desiredTime, ref FVector Vector);

		// Token: 0x06013A8A RID: 80522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointLifeAtTime_Internal(IntPtr @this, in int PointID, in float DesiredTime, ref float Value);

		// Token: 0x06013A8B RID: 80523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointLife_Internal(IntPtr @this, in int PointID, ref float Value);

		// Token: 0x06013A8C RID: 80524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointInt32ValueAtTime_Internal(IntPtr @this, int PointID, int AttributeIndex, float desiredTime, ref int Value);

		// Token: 0x06013A8D RID: 80525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointIDsToSpawnAtTime_Internal(IntPtr @this, in float desiredTime, ref int MinID, ref int MaxID, ref int Count, ref int LastSpawnedPointID, ref float LastSpawnTime, ref float LastSpawnTimeRequest);

		// Token: 0x06013A8E RID: 80526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPointFloatValueAtTime_Internal(IntPtr @this, int PointID, int AttributeIndex, float desiredTime, ref float Value);

		// Token: 0x06013A8F RID: 80527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfSamples_Internal(IntPtr @this);

		// Token: 0x06013A90 RID: 80528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfPoints_Internal(IntPtr @this);

		// Token: 0x06013A91 RID: 80529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfAttributes_Internal(IntPtr @this);

		// Token: 0x06013A92 RID: 80530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetNormalValue_Internal(IntPtr @this, in int sampleIndex, ref FVector value);

		// Token: 0x06013A93 RID: 80531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLifeValues_Internal(IntPtr @this);

		// Token: 0x06013A94 RID: 80532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLastSampleIndexAtTime_Internal(IntPtr @this, in float desiredTime, ref int lastSampleIndex);

		// Token: 0x06013A95 RID: 80533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLastPointIDToSpawnAtTime_Internal(IntPtr @this, in float time, ref int lastID);

		// Token: 0x06013A96 RID: 80534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetImpulseValue_Internal(IntPtr @this, in int sampleIndex, ref float value);

		// Token: 0x06013A97 RID: 80535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatValueForString_Internal(IntPtr @this, in int sampleIndex, in FString Attribute, ref float value);

		// Token: 0x06013A98 RID: 80536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatValue_Internal(IntPtr @this, in int sampleIndex, in int attrIndex, ref float value);

		// Token: 0x06013A99 RID: 80537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFloatSampleData_Internal(IntPtr @this);

		// Token: 0x06013A9A RID: 80538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetColorValue_Internal(IntPtr @this, in int sampleIndex, ref FLinearColor value);

		// Token: 0x06013A9B RID: 80539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAttributeIndexInArrayFromString_Internal(in FString InAttribute, IntPtr InAttributeArray, ref int OutAttributeIndex);

		// Token: 0x06013A9C RID: 80540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAttributeIndexFromString_Internal(IntPtr @this, in FString Attribute, ref int AttributeIndex);

		// Token: 0x06013A9D RID: 80541 RVA: 0x001CE1FC File Offset: 0x001CC3FC
		static UHoudiniPointCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniNiagara.HoudiniPointCache");
		}

		// Token: 0x06013A9E RID: 80542 RVA: 0x001CE20A File Offset: 0x001CC40A
		protected UHoudiniPointCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A9BD RID: 43453
		public new const string __ObjectPath = "/Script/HoudiniNiagara.HoudiniPointCache";

		// Token: 0x0400A9BE RID: 43454
		private static IntPtr _ClassPtr;

		// Token: 0x0400A9BF RID: 43455
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A9C0 RID: 43456
		internal static int __PropertyOffset_FileName;

		// Token: 0x0400A9C1 RID: 43457
		internal static int __PropertyOffset_NumberOfSamples;

		// Token: 0x0400A9C2 RID: 43458
		internal static int __PropertyOffset_NumberOfAttributes;

		// Token: 0x0400A9C3 RID: 43459
		internal static int __PropertyOffset_NumberOfPoints;

		// Token: 0x0400A9C4 RID: 43460
		internal static int __PropertyOffset_NumberOfFrames;

		// Token: 0x0400A9C5 RID: 43461
		internal static int __PropertyOffset_FirstFrame;

		// Token: 0x0400A9C6 RID: 43462
		internal static int __PropertyOffset_LastFrame;

		// Token: 0x0400A9C7 RID: 43463
		internal static int __PropertyOffset_MinSampleTime;

		// Token: 0x0400A9C8 RID: 43464
		internal static int __PropertyOffset_MaxSampleTime;

		// Token: 0x0400A9C9 RID: 43465
		internal static int __PropertyOffset_SourceCSVTitleRow;

		// Token: 0x0400A9CA RID: 43466
		internal static int __PropertyOffset_AttributeArray;

		// Token: 0x0400A9CB RID: 43467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AttributeArray;

		// Token: 0x0400A9CC RID: 43468
		internal static int __PropertyOffset_FloatSampleData;

		// Token: 0x0400A9CD RID: 43469
		[Nullable(2)]
		private TArray<float> _FloatSampleData;

		// Token: 0x0400A9CE RID: 43470
		internal static int __PropertyOffset_SpawnTimes;

		// Token: 0x0400A9CF RID: 43471
		[Nullable(2)]
		private TArray<float> _SpawnTimes;

		// Token: 0x0400A9D0 RID: 43472
		internal static int __PropertyOffset_LifeValues;

		// Token: 0x0400A9D1 RID: 43473
		[Nullable(2)]
		private TArray<float> _LifeValues;

		// Token: 0x0400A9D2 RID: 43474
		internal static int __PropertyOffset_PointTypes;

		// Token: 0x0400A9D3 RID: 43475
		[Nullable(2)]
		private TArray<int> _PointTypes;

		// Token: 0x0400A9D4 RID: 43476
		internal static int __PropertyOffset_SpecialAttributeIndexes;

		// Token: 0x0400A9D5 RID: 43477
		[Nullable(2)]
		private TArray<int> _SpecialAttributeIndexes;

		// Token: 0x0400A9D6 RID: 43478
		internal static int __PropertyOffset_PointValueIndexes;

		// Token: 0x0400A9D7 RID: 43479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPointIndexes> _PointValueIndexes;

		// Token: 0x0400A9D8 RID: 43480
		internal static int __PropertyOffset_UseCustomCSVTitleRow;

		// Token: 0x0400A9D9 RID: 43481
		internal static int __PropertyOffset_FileType;
	}
}
